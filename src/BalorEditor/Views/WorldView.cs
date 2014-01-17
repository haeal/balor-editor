using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalorEditor.Views
{
	public class WorldView
	{
		public const int RegionMapDimensions = 18;
		public const int BytesPerTile = 6;
		public const int TotalRegionCount = 42; //Not sure, but lines up perfectly with the file data.
		public const int RegionSize = RegionMapDimensions * RegionMapDimensions * BytesPerTile;

		private byte[] _worldViewData;
		private int _currentlySelectedRegion;
		private int _ewOffset;
		private int _nsOffset;

		public WorldView(byte[] data)
		{
			_worldViewData = data;
		}

		/// <summary>
		/// Selects the region.
		/// </summary>
		/// <param name="region">Must be %gt;= 0 and &lt; TotalRegionCount </param>
		/// <returns>The same object with the new region selected, pointing at the tile 0,0.</returns>
		public WorldView SelectRegion(int region)
		{
			if (region < 0 || region >= TotalRegionCount)
				throw new Exception("region");

			_currentlySelectedRegion = region;
			_ewOffset = 0;
			_nsOffset = 0;
			return this;
		}

		/// <summary>
		/// Selects the tile to view or edit.
		/// </summary>
		/// <param name="x">How many tiles "across" (from east to west). 0 offset.  Must be less than RegionMapDimensions</param>
		/// <param name="y">How many tiles "down" (from north to south). 0 offset.  Must be less than RegionMapDimensions</param>
		/// <returns>The same object with the new tile selected.</returns>
		public WorldView SelectTile(int x, int y)
		{
			if (x < 0 || x >= RegionMapDimensions)
				throw new ArgumentException("x");
			if (y < 0 || y >= RegionMapDimensions)
				throw new ArgumentException("y");

			_ewOffset = x;
			_nsOffset = y;
			return this;
		}

		/// <summary>
		/// The values are not just blocks of regions tagged onto each other.  Each region is grouped into 6, and accessing the xth in the yth row
		/// has to go across all 6 regions before going to the second line.
		/// </summary>
		/// <param name="f"></param>
		/// <returns></returns>
		private int Offset(Field f)
		{
			const int RegionsPerBlock = 6;
			int regionBlock = _currentlySelectedRegion / RegionsPerBlock;
			int offset = regionBlock * RegionSize * RegionsPerBlock; //Gets us into the right region block.
			//Get the yth row.
			offset += RegionMapDimensions * BytesPerTile * _nsOffset * RegionsPerBlock;
			//Get the xth region.
			offset += _currentlySelectedRegion % RegionsPerBlock * RegionMapDimensions * BytesPerTile;
			//Now get the actual field.
			offset += _ewOffset * BytesPerTile + (int)f;

			return offset;
			//return _currentlySelectedRegion * RegionSize + _nsOffset * RegionMapDimensions * BytesPerTile + _ewOffset * BytesPerTile + (int)f;
		}

		private enum Field
		{
			Unknown0 = 0,
			Density =1,
			MaterialType =2,
			OccupyingHero=3,
			Unknown1=4,
			Unknown2=5

		}

		public enum Material
		{
			Grassland = 0,
			Rock=1,
			TreePine=2,
			TreeOak=3,
			Farmland=4,
		}

		//public int Height { get { return _worldViewData[Offset(Field.Height)]; } set { _worldViewData[Offset(Field.Height)] = (byte)value; } }
		public int Density { get { return _worldViewData[Offset(Field.Density)]; } set { _worldViewData[Offset(Field.Density)] = (byte)value; } }
		public Material MaterialType { get { return (Material)_worldViewData[Offset(Field.MaterialType)]; } set { _worldViewData[Offset(Field.MaterialType)] = (byte)value; } }
		public int OccupyingHero { get { return _worldViewData[Offset(Field.OccupyingHero)]; } set { _worldViewData[Offset(Field.OccupyingHero)] = (byte)value; } }

		public IEnumerable<string> GetRegions()
		{
			for (int i = 1; i <= TotalRegionCount; i++)
				yield return "Region " + i;
		}

		public CellInfo GetCellInfo()
		{
			return new CellInfo
			{
				Unknown0 = _worldViewData[Offset(Field.Unknown0)],
				Density = _worldViewData[Offset(Field.Density)],
				MaterialType = _worldViewData[Offset(Field.Density)],
				OccupyingHero = _worldViewData[Offset(Field.OccupyingHero)],
				Unknown1 = _worldViewData[Offset(Field.Unknown1)],
				Unknown2 = _worldViewData[Offset(Field.Unknown2)],
			};
		}
	}

	public class CellInfo
	{
		public int Unknown0;
		public int Density;
		public int MaterialType;
		public int OccupyingHero;
		public int Unknown1;
		public int Unknown2;
	}
}
