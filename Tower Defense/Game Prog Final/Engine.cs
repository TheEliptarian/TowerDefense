using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace td
{
	public partial class Engine : Form
	{
		public static Form form;
		public static Sprite canvas = new Sprite();
		public static Thread UpdateThread;
		public static bool menu = true;
		public static int s = 100;
		public static int fps = 30;
		public static double running_fps = 30.0;
		public static Rectangle rect = new Rectangle(0, 0, 1400, 900, 200);
		public static TextSprite start = new TextSprite(0, 0, "Press Enter to start.");
		public static TextSprite level = new TextSprite(0, 0, "Press Enter on a level to select it. Arrow keys to move.");
		public static TextSprite text = new TextSprite(0, 0, "You Win!\nPress R to Restart.");
		public static TextSprite loss = new TextSprite(0, 0, "You Lose.\nPress R to Restart.");

		private void Engine_Load(object sender, EventArgs e)
		{

		}

		public Engine()
		{
			InitializeComponent();
			DoubleBuffered = true;
			form = this;
			UpdateThread = new Thread(new ThreadStart(update));
			UpdateThread.Start();
		}

		private void Sokoban_Load(object sender, EventArgs e) { }

		public static void update()
		{
			DateTime l = DateTime.Now;
			DateTime n = l;
			TimeSpan frame = new TimeSpan(10000000 / fps);
			while (true)
			{
				DateTime temp = DateTime.Now;
				n = temp;
				TimeSpan diff = n - l;
				if (diff.TotalMilliseconds < frame.TotalMilliseconds)
				{
					Thread.Sleep((frame - diff).Milliseconds);
				}
				l = DateTime.Now;
				canvas.update();
				form.Invoke(new MethodInvoker(form.Refresh));
			}
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//base.OnPaint(e);
			canvas.render(e.Graphics);
		}

		protected override

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			UpdateThread.Abort();
		}
	}
}