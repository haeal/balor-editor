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

		private PointInfo _selectedPoint;
		public WorldView.Material PaintMaterial = WorldView.Material.Grassland;

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
								g.FillRectangle(Brushes.Green, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
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
							case WorldView.Material.Burg:
								g.FillRectangle(Brushes.LightGray, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								g.DrawLine(Pens.Black, x * tileSize, y * tileSize, x * tileSize + tileSize - 1, y * tileSize + tileSize - 1);
								break;
							case WorldView.Material.Citadel:
								g.FillRectangle(Brushes.BurlyWood, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								g.DrawLine(Pens.Black, x * tileSize, y * tileSize, x * tileSize + tileSize - 1, y * tileSize + tileSize - 1);
								break;
							case WorldView.Material.Tent:
								g.FillRectangle(Brushes.LightYellow, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								g.DrawLine(Pens.Black, x * tileSize, y * tileSize, x * tileSize + tileSize - 1, y * tileSize + tileSize - 1);
								break;
							case WorldView.Material.Ocean:
								g.FillRectangle(Brushes.Blue, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.River:
								g.FillRectangle(Brushes.LightBlue, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
							case WorldView.Material.Shallows:
								g.FillRectangle(Brushes.LightGreen, x * tileSize, y * tileSize, tileSize - 1, tileSize - 1);
								break;
						}

						//Draw any people that may exist on that tile.
						if (_world.OccupyingHero < 158)
						{
							g.FillRectangle(Brushes.White, x * tileSize + tileSize / 4, y * tileSize + tileSize / 4, tileSize / 2, tileSize / 2);
							g.DrawRectangle(Pens.Black, x * tileSize + tileSize / 4, y * tileSize + tileSize / 4, tileSize / 2, tileSize / 2);
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
			int mouseX = e.X;
			int mouseY = e.Y;
			if (_selectedPoint != null)
			{
				mouseX = _selectedPoint.OriginalMouseX;
				mouseY = _selectedPoint.OriginalMouseY;

				//Get the difference between the current mouseX and the last one, divide by 4, and set the density to a max of 47.
				_world.Density = Math.Min(47, Math.Max(0, (e.X - _selectedPoint.OriginalMouseX) / 4));
			}

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

				if (mouseX < xOffset)
					return;

				if (mouseY < yOffset)
					return;

				int x = (mouseX - xOffset) / cellSize;
				int y = (mouseY - yOffset) / cellSize;

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

		private void WorldDisplay_MouseDown(object sender, MouseEventArgs e)
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

			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				_world.SelectTile(x, y);
				_selectedPoint = new PointInfo { X = x, Y = y, OriginalMouseX = e.X, OriginalMouseY = e.Y };
			}

			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				_world.SelectTile(x, y).MaterialType = PaintMaterial;
				if (PaintMaterial == WorldView.Material.Ocean)
					_world.TileImage = 0;
				else
					_world.TileImage = 36;
				//Repaint the landscape as we have changed what it looks like.
				_cachedRegionImage = null; WorldDisplay_SizeChanged(null, null); Refresh();
			}
		}

		private void WorldDisplay_MouseUp(object sender, MouseEventArgs e)
		{
			_selectedPoint = null;
		}
	}

	public class PointInfo
	{
		public int X;
		public int Y;
		public int OriginalMouseX;
		public int OriginalMouseY;
	}
}
