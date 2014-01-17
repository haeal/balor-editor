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
		private string _lastOpenedPath;
		private int _lastOpenedIndex;

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadSaveGameDialog dlg = new LoadSaveGameDialog();

			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			_lastOpenedPath = dlg.SelectedPath;
			_lastOpenedIndex = dlg.SelectedSaveGameIndex;
			LoadGameState();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Save out the heroes file.
			string fullPath = Path.Combine(_lastOpenedPath, "KPHEROS" + _lastOpenedIndex + ".DAT");
			File.Move(fullPath, fullPath.Replace(".DAT", "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".DAT"));
			File.WriteAllBytes(fullPath, _heroesList.GetData());
		}

		private void LoadGameState()
		{
			//Load up the hero view.
			byte[] data = File.ReadAllBytes(Path.Combine(_lastOpenedPath, "KPHEROS" + _lastOpenedIndex + ".DAT"));
			_heroesList = new HeroView(data);
			itemSelector1.Collection = _heroesList.GetHeroes().Select(x => new DataItem { Text = x.ToString() }).ToList();

			//Load up the region view.
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
