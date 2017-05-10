﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace td
{
	public class ImageSprite : Sprite
	{
		public Image image;
		public int width, height;

		public Image Image
		{
			get { return image; }
			set { image = value; }
		}

		public int Width
		{
			get { return width; }
			set { width = value; }
		}

		public int Height
		{
			get { return height; }
			set { height = value; }
		}

		public ImageSprite(Image img)
		{
			image = img;
			width = img.Width;
			height = img.Height;
		}

		public ImageSprite(Image img, int x, int y)
		{
			image = img;
			width = img.Width;
			height = img.Height;
			X = x;
			Y = y;
		}

		public override void paint(Graphics g)
		{
			g.DrawImage(image, 0, 0);
		}

	}
}