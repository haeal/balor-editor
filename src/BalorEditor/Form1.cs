using BalorEditor.FileHandling;
using BalorEditor.Views;
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
		private WorldView _worldView;

		private string _lastOpenedPath;
		private int _lastOpenedIndex;

		private bool _updatingPage1;

		private object _mutex = new object();

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LoadSaveGameDialog dlg = new LoadSaveGameDialog();

			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			_lastOpenedPath = dlg.SelectedPath;
			_lastOpenedIndex = dlg.SelectedSaveGameIndex;

			worldDisplay1.MouseOver += worldDisplay1_MouseOver;

			LoadGameState();
		}

		void worldDisplay1_MouseOver(object sender, CellInfo info)
		{
			if (info == null)
				toolStripStatusLabel1.Text = "";
			else
				toolStripStatusLabel1.Text = info.ToString();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lock (_mutex)
			{
				//Save out the heroes file.
				string fullPath = Path.Combine(_lastOpenedPath, "KPHEROS" + _lastOpenedIndex + ".DAT");
				//File.Move(fullPath, fullPath.Replace(".DAT", "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".DAT"));
				File.WriteAllBytes(fullPath, _heroesList.GetData());

				//Save out the world file.
				fullPath = Path.Combine(_lastOpenedPath, "KPWORLD" + _lastOpenedIndex + ".DAT");
				//File.Move(fullPath, fullPath.Replace(".DAT", "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".DAT"));
				File.WriteAllBytes(fullPath, _worldView.GetData());
			}
		}

		private void LoadGameState()
		{
			//Load up the hero view.
			byte[] data = File.ReadAllBytes(Path.Combine(_lastOpenedPath, "KPHEROS" + _lastOpenedIndex + ".DAT"));
			_heroesList = new HeroView(data);
			itemSelector1.Collection = _heroesList.GetHeroes().Select(x => new DataItem { Text = x.ToString() }).ToList();

			//Load up the region view.
			data = File.ReadAllBytes(Path.Combine(_lastOpenedPath, "KPWORLD" + _lastOpenedIndex + ".DAT"));
			_worldView = new WorldView(data);
			worldDisplay1.World = _worldView;
			isRegion.Collection = _worldView.GetRegions().Select(x => new DataItem { Text = x.ToString() }).ToList();
			worldDisplay1.RedrawRegion();
		}

		private void itemSelector1_ItemSelectorIndexChanged(object sender, int index)
		{
			_updatingPage1 = true;
			_heroesList.SelectHero(index);

			lbName.Text = _heroesList.Name;
			udLevel.Value = _heroesList.Level;
			udArms.Value = _heroesList.Arms;
			udDex.Value = _heroesList.Dexterity;
			udMind.Value = _heroesList.Mind;
			udCharm.Value = _heroesList.Charm;

			cbPlayerOwned.Checked = _heroesList.PlayerOwned;
			udGroup.Value = _heroesList.PlayerGroup;

			//Populate all the skills that hero has.
			gbSkills.Controls.OfType<CheckBox>().ToList().ForEach(x => x.Checked = ((int)_heroesList.Skills & (1 << x.TabIndex)) != 0);
			_updatingPage1 = false;
		}

		private void Page1AnyValueChanged(object sender, EventArgs e)
		{
			if (_updatingPage1)
				return;
			_heroesList.Level = (int)udLevel.Value;
			_heroesList.Arms = (int)udArms.Value;
			_heroesList.Dexterity = (int)udDex.Value;
			_heroesList.Mind = (int)udMind.Value;
			_heroesList.Charm = (int)udCharm.Value;

			_heroesList.PlayerOwned = cbPlayerOwned.Checked;
			_heroesList.PlayerGroup = (int)udGroup.Value;

			//Populate all the skills that hero has.
			_heroesList.Skills = (HeroView.Skill)gbSkills.Controls.OfType<CheckBox>().ToList().Select(x => x.Checked ? (int)Math.Pow(2, x.TabIndex) : 0).Aggregate((x, y) => x | y);
		}

		private void isRegion_ItemSelectorIndexChanged(object sender, int index)
		{
			_worldView.SelectRegion(index);
			worldDisplay1.RedrawRegion();
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

		private void rbMaterialSelected(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if (rb.Checked)
				worldDisplay1.PaintMaterial = (WorldView.Material)rb.TabIndex;
		}

		private void btnResetHeights_Click(object sender, EventArgs e)
		{
			for (int y = 0; y < WorldView.RegionMapDimensions; y++)
			{
				for (int x = 0; x < WorldView.RegionMapDimensions; x++)
				{
					_worldView.SelectTile(x, y);
					//Ignore the buildings or rivers/shallows.
					if (_worldView.MaterialType == WorldView.Material.Burg || _worldView.MaterialType == WorldView.Material.Citadel || _worldView.MaterialType == WorldView.Material.Citadel ||
						_worldView.MaterialType == WorldView.Material.River || _worldView.MaterialType == WorldView.Material.Shallows)
						continue;

					if (_worldView.MaterialType == WorldView.Material.Ocean)
						_worldView.TileImage = 0;
					else
						_worldView.TileImage = 36;
				}
			}
		}

		private void btnTileTest_Click(object sender, EventArgs e)
		{
			//Go through all possible values that could be used for the sprite table dependant on the terrain.
			//Use the ocean first.  Since it is hard to count, alternate ocean with grassland.
			for (int y = 0; y < 4; y++)
			{
				for (int x = 0; x < 8; x++)
				{
					_worldView.SelectTile(x * 2, y * 2);
					_worldView.MaterialType = WorldView.Material.Grassland;
					_worldView.TileImage = 0;
					_worldView.Density = 0;

					_worldView.SelectTile(x * 2 + 1, y * 2);
					_worldView.MaterialType = worldDisplay1.PaintMaterial;
					_worldView.TileImage = (int)udTileTester.Value + y * 8 + x;
					_worldView.Density = 0;
				}

				for (int i = 0; i < 2; i++)
				{
					_worldView.SelectTile(16 + i, y);
					_worldView.MaterialType = WorldView.Material.Grassland;
					_worldView.TileImage = 0;
					_worldView.Density = 0;
				}

				for (int x = 0; x < WorldView.RegionMapDimensions; x++)
				{
					_worldView.SelectTile(x, y * 2 + 1);
					_worldView.MaterialType = WorldView.Material.Grassland;
					_worldView.TileImage = 0;
					_worldView.Density = 0;
				}
			}
			worldDisplay1.RedrawRegion();
		}

		private void udTileTester_ValueChanged(object sender, EventArgs e)
		{
			btnTileTest_Click(null, null);
			saveToolStripMenuItem_Click(null, null);
		}
	}
}
