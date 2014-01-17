using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalorEditor
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private HeroView _heroesList;
		private string _lastOpenedFile;

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "KPHEROS*.dat|KPHEROS*.dat";

			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			LoadGameState(dlg.FileName);
			_lastOpenedFile = dlg.FileName;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			File.Move(_lastOpenedFile, _lastOpenedFile.Replace(".DAT", "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".DAT"));
			File.WriteAllBytes(_lastOpenedFile, _heroesList.GetData());
		}

		private void LoadGameState(string path)
		{
			byte[] data = File.ReadAllBytes(path);
			_heroesList = new HeroView(data);
			itemSelector1.Collection = _heroesList.GetHeroes().Select(x => new DataItem { Text = x.ToString() }).ToList();
		}

		private void itemSelector1_ItemSelectorIndexChanged(object sender, int index)
		{
			_heroesList.SelectHero(index);

			lbName.Text = _heroesList.Name;
			udLevel.Value = _heroesList.Level;
			udArms.Value = _heroesList.Arms;
			udDex.Value = _heroesList.Dexterity;
			udMind.Value = _heroesList.Mind;
			udCharm.Value = _heroesList.Charm;

			cbPlayerOwned.Checked = _heroesList.PlayerOwned;
			udGroup.Value = _heroesList.PlayerGroup;
		}

		private void btnMaxStats_Click(object sender, EventArgs e)
		{
			var list = _heroesList.GetHeroes().Select(x => new { Idx = x, PlayerOwned = _heroesList.SelectHero(x).PlayerOwned }).Where(x => x.PlayerOwned).ToList();
			foreach (var v in list)
			{
				_heroesList.SelectHero(v.Idx);
				_heroesList.Arms = 240;
				_heroesList.Dexterity = 240;
				_heroesList.Mind = 240;
				_heroesList.Charm = 240;
			}

			int selectedIndex = 0;
			if (list.Count() > 0)
				selectedIndex = list[0].Idx;

			itemSelector1_ItemSelectorIndexChanged(null, selectedIndex);
		}

	}
}
