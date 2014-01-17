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

		public delegate void CellInfoEvent(object sender, CellInfo info);
		public event CellInfoEvent MouseOver;

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
							case WorldView.Material.Grassland:
								if (_world.Density > 0)
									g.FillRectangle(Brushes.Green, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								else
									g.FillRectangle(Brushes.Blue, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.Rock:
								g.FillRectangle(Brushes.Gray, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.TreeOak:
							case WorldView.Material.TreePine:
								g.FillRectangle(Brushes.DarkGreen, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.Farmland:
								g.FillRectangle(Brushes.Yellow, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
						}

						//Draw any people that may exist on that tile.
						if (_world.OccupyingHero != 0)
							g.FillRectangle(Brushes.White, x * tileSize + tileSize / 4, y * tileSize + tileSize / 4, tileSize / 2, tileSize / 2);
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
			int width = Width / WorldView.RegionMapDimensions * WorldView.RegionMapDimensions;
			int height = Height / WorldView.RegionMapDimensions * WorldView.RegionMapDimensions;
			if (width > height)
				width = height;
			if (height > width)
				height = width;

			if (_cachedRegionImage == null || width != _cachedRegionImage.Width || height != _cachedRegionImage.Height)
				_cachedRegionImage = DrawBitmap(width, height);
		}

		//Collide with whatever we are over and give feedback on the field.
		private void WorldDisplay_MouseMove(object sender, MouseEventArgs e)
		{
			CellInfo toInvoke = null;

			if (MouseOver == null)
				return;

			try
			{

				if (_cachedRegionImage == null)
					return;

				//Find out where the mouse is in regards to the overlay and return the info.
				int cellSize = _cachedRegionImage.Width / WorldView.RegionMapDimensions;
				int xOffset = (Width - _cachedRegionImage.Width) / 2;
				int yOffset = (Height - _cachedRegionImage.Height) / 2;

				if (e.X < xOffset)
					return;

				if (e.Y < yOffset)
					return;

				int x = (e.X - xOffset) / cellSize;
				int y = (e.Y - yOffset) / cellSize;

				if (x >= WorldView.RegionMapDimensions)
					return;

				if (y >= WorldView.RegionMapDimensions)
					return;

				toInvoke = _world.SelectTile(x, y).GetCellInfo();
			}
			finally
			{
				MouseOver.Invoke(this, toInvoke);
			}
		}
	}
}
