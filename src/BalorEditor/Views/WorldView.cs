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

		private int Offset(Field f)
		{
			return _currentlySelectedRegion * RegionSize + _nsOffset * RegionMapDimensions * BytesPerTile + _ewOffset * BytesPerTile + (int)f;
		}

		private enum Field
		{
			Height, //? Maybe???
			NotSure1,
			Density,
			MaterialType,
			OccupyingHero
		}

		public enum Material
		{
			Ocean,
			Grassland,
			Rock,
			TreePine,
			TreeOak,
		}

		public int Height { get { return _worldViewData[Offset(Field.Height)]; } set { _worldViewData[Offset(Field.Height)] = (byte)value; } }
		public int Density { get { return _worldViewData[Offset(Field.Density)]; } set { _worldViewData[Offset(Field.Density)] = (byte)value; } }
		public Material MaterialType { get { return (Material)_worldViewData[Offset(Field.Density)]; } set { _worldViewData[Offset(Field.Density)] = (byte)value; } }
		public int OccupyingHero { get { return _worldViewData[Offset(Field.OccupyingHero)]; } set { _worldViewData[Offset(Field.OccupyingHero)] = (byte)value; } }

		public IEnumerable<string> GetRegions()
		{
			for (int i = 1; i <= TotalRegionCount; i++)
				yield return "Region " + i;
		}
	}
}
