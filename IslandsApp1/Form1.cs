using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IslandsApp1
{
	public partial class Form1 : Form
	{
		Bitmap finalImage;
		bool DoneLoadFlag = false;
		List<Bitmap> bmpMas = new List<Bitmap>();
		List<Bitmap> Levels = new List<Bitmap>();
		List<byte[]> Islands = new List<byte[]>();
		List<Bitmap> Flames = new List<Bitmap>();
		List<Bitmap> Explosions = new List<Bitmap>();
		List<Bitmap> Rectangles = new List<Bitmap>();
		List<Point> KraterTiles = new List<Point>();
		Point ExplosionXY = new Point();
		bool ExplosionFlag = false;
		Bitmap[] Kursor = new Bitmap[2];
		Bitmap GreenTile;
		int KursorX = 0;
		int KursorY = 0;
		int flamesCounter = 0;
		int explosionsCounter = 0;
		Bitmap[] Krater = new Bitmap[3];
		List<Point> ValidPlace = new List<Point>();
		bool ValidCursorFlag = false;
		int FPS = 30;
		//#################################################################################
		private void WriteFile()
		{
			int[] mas = new int[10];
			StreamWriter str = new StreamWriter("temp.txt");
			for (int i = 0; i < 100; i++)
			{
				str.WriteLine(mas[i]);
			}
			str.Close();
		}

		private void ReadValidPlaces(int IslandNum)
		{

			try
			{
				string[] separatingStrings = { Environment.NewLine };


				string[] words = null;

				switch (IslandNum)
				{
					case 0:
						words = res.island1d.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
						break;
					case 1:
						words = res.island2d.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
						break;
					case 2:
						words = res.island3d.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
						break;
					case 3:
						words = res.island4d.Split(separatingStrings, StringSplitOptions.RemoveEmptyEntries);
						break;
				}



				ValidPlace.Clear();
				for (int i = 0; i < words.Count(); i += 2)
					ValidPlace.Add(new Point(int.Parse(words[i]), int.Parse(words[i + 1])));
			}
			catch { }
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{ // 587; 534
			ReadValidPlaces(0);

			MakeBuildMenu(res.menu);

			pic.Width = 552;
			pic.Height = 480;


			Kursor[0] = res.rectangles.Clone(new Rectangle(0, 24, 48, 24), PixelFormat.Format16bppArgb1555);
			Kursor[1] = res.rectangles.Clone(new Rectangle(48, 24, 48, 24), PixelFormat.Format16bppArgb1555);

			Rectangle rect = new Rectangle(48, 0, 48, 24);
			GreenTile = res.rectangles.Clone(rect, PixelFormat.Format16bppArgb1555);

			Levels.Add(res.tiles1);
			Levels.Add(res.tiles2);
			Levels.Add(res.tiles3);

			Islands.Add(res.island1);
			Islands.Add(res.island2);
			Islands.Add(res.island3);
			Islands.Add(res.island4);

			for (int i = 0; i < 4; i++)
			{
				if (i < 3)
				{
					Krater[i] = res.rectangles.Clone(new Rectangle((i + 3) * 48, 24, 48, 24), PixelFormat.Format16bppArgb1555);
					lstMap.Items.Add("Погода " + (i + 1).ToString());
				}
				lstIsland.Items.Add("Острів " + (i + 1).ToString());
			}

			lstMap.SelectedIndex = 0;
			lstIsland.SelectedIndex = 0;

			DoneLoadFlag = true;

			//MakeLevel(0, 0);

			PrepareFlames(res.flames);
			PrepareExplosions(res.explosions);


			tmrFlames.Enabled = true;
			tmrMain.Interval = 1000 / 15;
			tmrMain.Enabled = true;
		}

		private void MakeBuildMenu(Bitmap bmp)
		{
			rbBuildMissileSilo.Image = bmp.Clone(new Rectangle(0, 0, 30, 30), PixelFormat.Format16bppArgb1555);
			rbBuildShieldGenerator.Image = bmp.Clone(new Rectangle(0, 30, 30, 30), PixelFormat.Format16bppArgb1555);
			rbBuildPowerPlant.Image = bmp.Clone(new Rectangle(0, 60, 30, 30), PixelFormat.Format16bppArgb1555);
			rbBuildAirField.Image = bmp.Clone(new Rectangle(0, 90, 30, 30), PixelFormat.Format16bppArgb1555);
			rbBuildLaboratory.Image = bmp.Clone(new Rectangle(0, 120, 30, 30), PixelFormat.Format16bppArgb1555);
			rbBuildFactory.Image = bmp.Clone(new Rectangle(0, 150, 30, 30), PixelFormat.Format16bppArgb1555);
			//
			rbAttackMissile.Image = bmp.Clone(new Rectangle(30, 0, 30, 30), PixelFormat.Format16bppArgb1555);
			rbAttackAirStrike.Image = bmp.Clone(new Rectangle(30, 30, 30, 30), PixelFormat.Format16bppArgb1555);
			rbAttackArtillery.Image = bmp.Clone(new Rectangle(30, 60, 30, 30), PixelFormat.Format16bppArgb1555);
			rbAttackSpySatelite.Image = bmp.Clone(new Rectangle(30, 90, 30, 30), PixelFormat.Format16bppArgb1555);
			rbAttackNuke.Image = bmp.Clone(new Rectangle(30, 120, 30, 30), PixelFormat.Format16bppArgb1555);
			rbAttackShield.Image = bmp.Clone(new Rectangle(30, 150, 30, 30), PixelFormat.Format16bppArgb1555);
		}

		private void PrepareFlames(Bitmap bmp)
		{
			Flames.Clear();
			Rectangle rect;
			for (int i = 0; i < 4; i++)
			{
				rect = new Rectangle(i * 20, 0, 20, 36);
				Flames.Add(bmp.Clone(rect, PixelFormat.Format16bppArgb1555));
				GC.Collect();
			}
		}

		private void PrepareExplosions(Bitmap bmp)
		{
			Explosions.Clear();
			for (int i = 0; i < 6; i++)
			{
				Explosions.Add(bmp.Clone(new Rectangle(i * 26, 0, 26, 26), PixelFormat.Format16bppArgb1555));
			}
			GC.Collect();
		}

		private void MakeLevel(int level, int island)
		{
			LoadMapImages(Levels[level]);
			PaintLevel(Islands[island]);
		}

		private void LoadMapImages(Bitmap bmp)
		{
			bmpMas.Clear();
			Rectangle rect;
			int n = 0, k = 0;
			for (int i = 0; i < 34; i++)
			{
				rect = new Rectangle(k * 24, n * 24, 24, 24);
				k++;
				if (k == 8) { k = 0; n++; }
				bmpMas.Add(bmp.Clone(rect, PixelFormat.Format16bppArgb1555));
				GC.Collect();
			}
		}


		private void PaintLevel(byte[] LevelMas)
		{
			finalImage = new Bitmap(600, 600);
			using (Graphics g = Graphics.FromImage(finalImage))
			{
				//g.RotateTransform(-28,System.Drawing.Drawing2D.MatrixOrder.Prepend);
				g.Clear(Color.Black);
				int k = 0, n = 0;
				for (int i = 0; i < 460; i++)
				{
					g.DrawImage(bmpMas[LevelMas[i]], new Rectangle(k * 24, n * 24, 24, 24));
					k++;
					if (k == 23) { k = 0; n++; }
				}
				foreach (Point p in KraterTiles)
					g.DrawImage(Krater[lstMap.SelectedIndex], new Rectangle(p.X, p.Y, 48, 24));

				if (ExplosionFlag)
				{
					g.DrawImage(Explosions[explosionsCounter], new Rectangle(ExplosionXY.X + 12, ExplosionXY.Y - 12, 24, 24));
					explosionsCounter++;
					if (explosionsCounter == 6) { explosionsCounter = 0; ExplosionFlag = false; }
					GC.Collect();
				}

				if (ValidCursorFlag)
					g.DrawImage(Kursor[0], new Rectangle(KursorX, KursorY, 48, 24));
				//else
					g.DrawImage(Kursor[1], new Rectangle(KursorX, KursorY, 48, 24));


				//g.DrawLine(new Pen(Color.Red, 5), DateTime.Now.Second*3, 0, 60-DateTime.Now.Second, 50);
			}
			pic.Image = finalImage;
			GC.Collect();
		}

		private bool IsKursorValid(int x, int y)
		{
			Point tmp = new Point(x, y);
			if (ValidPlace.Contains(tmp))
				return true;
			return false;
		}

		private void lstMap_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DoneLoadFlag) MakeLevel(lstMap.SelectedIndex, lstIsland.SelectedIndex);
		}

		private void lstIsland_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DoneLoadFlag)
			{
				ReadValidPlaces(lstIsland.SelectedIndex);
				MakeLevel(lstMap.SelectedIndex, lstIsland.SelectedIndex);
			}
		}

		private void tmrFlames_Tick(object sender, EventArgs e)
		{
			picFlames.Image = null;
			picFlames.Image = Flames[flamesCounter];
			flamesCounter++;
			if (flamesCounter == 4) flamesCounter = 0;
			GC.Collect();
		}

		private void RandomMap()
		{
			DoneLoadFlag = false;
			Random rnd = new Random();
			lstMap.SelectedIndex = rnd.Next(3);
			lstIsland.SelectedIndex = rnd.Next(4);
			MakeLevel(lstMap.SelectedIndex, lstIsland.SelectedIndex);
			DoneLoadFlag = true;
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			return;
			if (e.KeyCode == Keys.Up)
			{
				KursorX += 24;
				KursorY -= 12;
			}
			if (e.KeyCode == Keys.Down)
			{
				KursorX -= 24;
				KursorY += 12;
			}
			if (e.KeyCode == Keys.Right)
			{
				KursorX += 24;
				KursorY += 12;
			}
			if (e.KeyCode == Keys.Left)
			{
				KursorX -= 24;
				KursorY -= 12;
			}
			if (e.KeyCode == Keys.Space)
			{

			}
			if (e.KeyCode == Keys.Enter)
			{
				if (e.Modifiers == Keys.Shift)
				{
					if (lstMap.SelectedIndex == lstMap.Items.Count - 1) lstMap.SelectedIndex = 0; else lstMap.SelectedIndex++;
				}
				else if (e.Modifiers == Keys.Control)
				{
					if (lstIsland.SelectedIndex == lstIsland.Items.Count - 1) lstIsland.SelectedIndex = 0; else lstIsland.SelectedIndex++;
				}
				else if (e.Modifiers == Keys.Alt)
				{
					RandomMap();
				}
				else if (!ExplosionFlag && ValidCursorFlag)
				{
					ExplosionXY.X = KursorX;
					ExplosionXY.Y = KursorY;
					ExplosionFlag = true;
					KraterTiles.Add(new Point(KursorX, KursorY));
				}
			}
			ValidCursorFlag = IsKursorValid(KursorX, KursorY);
		}

		private void tmrMain_Tick(object sender, EventArgs e)
		{
			MakeLevel(lstMap.SelectedIndex, lstIsland.SelectedIndex);
		}

		int tmpX = 0; int tmpY = 0;
		int dx = 0; int dy = 0;
		private void pic_MouseMove(object sender, MouseEventArgs e)
		{
			dx = e.X % 24;
			dy = e.Y % 12;
			//
			if (dx > 12)
				tmpX = e.X - dx;
			else
				tmpX = e.X - 24 - dx;
			//
			if (dy > 6)
				tmpY = e.Y - dy;
			else
				tmpY = e.Y - 12 - dy;
			//
			if (IsKursorValid(tmpX, tmpY))
			{
				KursorX = tmpX;
				KursorY = tmpY;
			}
			ValidCursorFlag = IsKursorValid(KursorX, KursorY);
		}

		private void pic_MouseDown(object sender, MouseEventArgs e)
		{
			if (ValidCursorFlag)
			{
				if (!ExplosionFlag)
				{
					ExplosionXY.X = KursorX;
					ExplosionXY.Y = KursorY;
					ExplosionFlag = true;
					KraterTiles.Add(new Point(KursorX, KursorY));
				}
			}
		}

		private void btnClearFire_Click(object sender, EventArgs e)
		{
			KraterTiles.Clear();
		}

		private void rbBuildMissileSilo_MouseEnter(object sender, EventArgs e)
		{
			lblBuildInfo.Text=((RadioButton)sender).Tag.ToString();
		}

		private void rbBuildMissileSilo_MouseLeave(object sender, EventArgs e)
		{
			lblBuildInfo.Text = "";
		}
	}
}
