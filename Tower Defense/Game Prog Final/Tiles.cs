using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace td
{
	class Tile : ImageSprite
	{
		public Tile(Image img) : base(img) { }
		public Tile(Image img, int x, int y) : base(img, x, y) { } 
	}

	class pathTile : Tile
	{
		public bool slows;

		public pathTile(Image img) : base(img) { }
		public pathTile(Image img, int x, int y) : base(img, x, y) { }
	}

	class placeTile : Tile
	{

		public placeTile(Image img) : base(img) { }
		public placeTile(Image img, int x, int y) : base(img, x, y) { }
	}
}
