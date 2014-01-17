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

namespace BalorEditor.FileHandling
{
	public partial class LoadSaveGameDialog : Form
	{
		private RadioButton[] _checkboxes;

		public string SelectedPath;
		public int SelectedSaveGameIndex;

		public LoadSaveGameDialog()
		{
			InitializeComponent();

			_checkboxes = new RadioButton[6];
			_checkboxes[0] = cbGame1;
			_checkboxes[1] = cbGame2;
			_checkboxes[2] = cbGame3;
			_checkboxes[3] = cbGame4;
			_checkboxes[4] = cbGame5;
			_checkboxes[5] = cbGame6;

			//Disable the ok button until a proper save game is selected
		}

		private void LoadSaveGameDialog_Load(object sender, EventArgs e)
		{
			tbPath.Text = Properties.Settings.Default.Path;
			PopulateSaveGames();
		}

		private void tbPath_TextChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.Path = tbPath.Text;
			Properties.Settings.Default.Save();

			PopulateSaveGames();
		}

		private void PopulateSaveGames()
		{
			var results = Directory.GetFiles(tbPath.Text, "KPWORLD*.DAT", SearchOption.TopDirectoryOnly);

			foreach (var v in _checkboxes)
			{
				v.Checked = false;
				v.Enabled = false;
			}

			foreach (var v in results)
			{
				int value = int.Parse(string.Join("", v.Substring(v.IndexOf("\\KPWORLD") + 8).Take(1)));
				if (value == 0) //Autosave file I think.
					continue;
				_checkboxes[value - 1].Enabled = true;
			}

			btnOk.Enabled = false;
		}

		private void Finish(int index)
		{
			SelectedPath = tbPath.Text;
			SelectedSaveGameIndex = index;
			btnOk.Enabled = true;
		}

		private void cbGame1_CheckedChanged(object sender, EventArgs e)
		{
			Finish(1);
		}

		private void cbGame2_CheckedChanged(object sender, EventArgs e)
		{
			Finish(2);
		}

		private void cbGame3_CheckedChanged(object sender, EventArgs e)
		{
			Finish(3);
		}

		private void cbGame4_CheckedChanged(object sender, EventArgs e)
		{
			Finish(4);
		}

		private void cbGame5_CheckedChanged(object sender, EventArgs e)
		{
			Finish(5);
		}

		private void cbGame6_CheckedChanged(object sender, EventArgs e)
		{
			Finish(6);
		}
	}
}
