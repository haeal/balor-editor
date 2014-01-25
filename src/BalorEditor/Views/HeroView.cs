using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalorEditor.Views
{
	public class HeroView
	{
		/// <summary>
		/// Size of each warrior's data chunk.
		/// </summary>
		public const int HeroChunkSize = 38;

		private int _heroOffset;
		private byte[] _hd;

		public HeroView(byte[] data)
		{
			_hd = data;
		}

		public HeroView SelectHero(int heroOffset)
		{
			_heroOffset = heroOffset;
			return this;
		}

		public string Name { get { return _heroOffset.ToString(); } }
		public bool PlayerOwned { get { return (_hd[Offset(Field.PlayerState)] & 0x80) != 0; } set { _hd[Offset(Field.PlayerState)] |= (byte)(value ? 0x80 : 0); } } //Not sure if correct.
		public int PlayerGroup { get { return _hd[Offset(Field.PlayerState)] & 0x7F; } set { _hd[Offset(Field.PlayerState)] = (byte)value; } }
		public int Level { get { return _hd[Offset(Field.Level)]; } set { _hd[Offset(Field.Level)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Charm { get { return _hd[Offset(Field.Charm)]; } set { _hd[Offset(Field.Charm)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Dexterity { get { return _hd[Offset(Field.Dexterity)]; } set { _hd[Offset(Field.Dexterity)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Mind { get { return _hd[Offset(Field.Mind)]; } set { _hd[Offset(Field.Mind)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Arms { get { return _hd[Offset(Field.Arms)]; } set { _hd[Offset(Field.Arms)] = (byte)Math.Min(255, Math.Max(0, value)); } }
		public int Experience
		{
			get { return _hd[Offset(Field.Experience)] | _hd[Offset(Field.Experience) + 1] << 8; }
			set { _hd[Offset(Field.Experience)] = (byte)(value & 0xFF); _hd[Offset(Field.Experience) + 1] = (byte)((value >> 8) & 0xFF); }
		}
		public Skill Skills
		{
			get { return (Skill)(_hd[Offset(Field.Skills)] | _hd[Offset(Field.Skills) + 1] << 8); }
			set { _hd[Offset(Field.Skills)] = (byte)value; _hd[Offset(Field.Skills) + 1] = (byte)(((int)value) >> 8); }
		}


		private int Offset(Field f)
		{
			return _heroOffset * HeroChunkSize + (int)f;
		}

		[Flags]
		public enum Skill : short
		{
			Elements = 1,
			Heroism = 2,
			Form = 4,
			Nature = 8,
			Parley = 16,
			Land = 32,
			Animal = 64,
			Might = 128,
			Masonry = 256,
			Vitality = 512,
			Barter = 1024,
			Crafts = 2048,
			Politics = 4096,
			Stealth = 8192,
			Spells = 16384

		}

		private enum Field
		{
			PlayerState = 4,
			Level = 5,
			Charm,
			Dexterity,
			Mind,
			Arms = 11,
			Experience = 18,
			Skills = 20,
		}

		public IEnumerable<int> GetHeroes()
		{
			for (int i = 0; i < _hd.Length / HeroChunkSize; i++)
				yield return i;
		}

		internal byte[] GetData()
		{
			return _hd.ToArray(); //Clone so no one can get at the internal data.  :D
		}
	}
}
