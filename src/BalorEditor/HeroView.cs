using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalorEditor
{
	public class HeroView
	{
		/// <summary>
		/// Size of each warrior's data chunk.
		/// </summary>
		public const int HeroChunkSize = 38;

		private int _heroOffset;
		private byte[] _heroData;

		public HeroView(byte[] data)
		{
			_heroData = data;
		}

		public HeroView SelectHero(int heroOffset)
		{
			_heroOffset = heroOffset;
			return this;
		}

		public string Name { get { return _heroOffset.ToString(); } }
		public bool PlayerOwned { get { return (_heroData[Offset(Field.PlayerState)] & 0x80) != 0; } set { _heroData[Offset(Field.PlayerState)] |= (byte)(value ? 0x80 : 0); } } //Not sure if correct.
		public int PlayerGroup { get { return _heroData[Offset(Field.PlayerState)] & 0x7F; } set { _heroData[Offset(Field.PlayerState)] = (byte)value; } }
		public int Level { get { return _heroData[Offset(Field.Level)]; } set { _heroData[Offset(Field.Level)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Charm { get { return _heroData[Offset(Field.Charm)]; } set { _heroData[Offset(Field.Charm)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Dexterity { get { return _heroData[Offset(Field.Dexterity)]; } set { _heroData[Offset(Field.Dexterity)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Mind { get { return _heroData[Offset(Field.Mind)]; } set { _heroData[Offset(Field.Mind)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Arms { get { return _heroData[Offset(Field.Arms)]; } set { _heroData[Offset(Field.Arms)] = (byte)Math.Min(255, Math.Max(0, value)); } }

		private int Offset(Field f)
		{
			return _heroOffset * HeroChunkSize + (int)f;
		}

		public enum Field
		{
			PlayerState = 4,
			Level = 5,
			Charm,
			Dexterity,
			Mind,
			Arms = 11,
		}

		public IEnumerable<int> GetHeroes()
		{
			for (int i = 0; i < _heroData.Length / HeroChunkSize; i++)
				yield return i;
		}

		internal byte[] GetData()
		{
			return _heroData.ToArray(); //Clone so no one can get at the internal data.  :D
		}
	}
}
