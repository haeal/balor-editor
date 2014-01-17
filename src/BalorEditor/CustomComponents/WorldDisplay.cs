using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BalorEditor.Views;

namespace BalorEditor.CustomComponents
{
	public partial class WorldDisplay : UserControl
	{
		private Bitmap _cachedRegionImage;
		private WorldView _world;
		public WorldView World { set { _world = value; _cachedRegionImage = null; WorldDisplay_SizeChanged(null, null); Refresh(); } }

		public WorldDisplay()
		{
			InitializeComponent();
			DoubleBuffered = true;
		}

		public void RedrawRegion()
		{
			_cachedRegionImage = null;
			WorldDisplay_SizeChanged(null, null);
			Refresh();
		}

		private Bitmap DrawBitmap(int width, int height)
		{
			Bitmap b = new Bitmap(width, height);
			Graphics g = Graphics.FromImage(b);

			g.FillRectangle(Brushes.Black, 0, 0, width, height);

			if (_world != null)
			{
				int tileSize = b.Width / WorldView.RegionMapDimensions;

				for (int y = 0; y < WorldView.RegionMapDimensions; y++)
				{
					for (int x = 0; x < WorldView.RegionMapDimensions; x++)
					{
						_world.SelectTile(x, y);

						//Draw based on properties.
						switch (_world.MaterialType)
						{
							case WorldView.Material.Ocean:
								g.FillRectangle(Brushes.Blue, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.Grassland:
								g.FillRectangle(Brushes.Yellow, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.Rock:
								g.FillRectangle(Brushes.Gray, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.TreeOak:
							case WorldView.Material.TreePine:
								g.FillRectangle(Brushes.Green, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
						}
					}
				}
			}

			return b;
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(Brushes.SkyBlue, 0, 0, Width, Height);

			if (_cachedRegionImage == null)
				return;
			int left = (Width - _cachedRegionImage.Width) / 2;
			int top = (Height - _cachedRegionImage.Height) / 2;

			e.Graphics.DrawImage(_cachedRegionImage, left, top);
		}

		private void WorldDisplay_SizeChanged(object sender, EventArgs e)
		{
			int width = Width / 18 * 18;
			int height = Height / 18 * 18;
			if (width > height)
				width = height;
			if (height > width)
				height = width;

			if (_cachedRegionImage == null || width != _cachedRegionImage.Width || height != _cachedRegionImage.Height)
				_cachedRegionImage = DrawBitmap(width, height);
		}
	}
}
