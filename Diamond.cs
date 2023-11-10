using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace WindowsApplication22
{
	/// <summary>
	/// Summary description for Stone.
	/// </summary>
	public class Diamond
	{
		public Point Position;
		public static Bitmap DiamondImage = null;

		public Diamond()
		{
			//
			// TODO: Add constructor logic here
			//
			Position.X = 0;
			Position.Y = 0;
			if (DiamondImage  == null)
			{
				DiamondImage = new Bitmap("diamond.gif");
			}
		}

		public Diamond(int x, int y)
		{
			//
			// TODO: Add constructor logic here
			//
			Position.X = x;
			Position.Y = y;
			if (DiamondImage  == null)
			{
				DiamondImage = new Bitmap("diamond.gif");
			}
		}

		public Rectangle GetFrame()
		{
			Rectangle myRect = new Rectangle(Position.X, Position.Y, DiamondImage.Width, DiamondImage.Height);
			return myRect;
		}

		public void Draw(Graphics g)
		{
			Rectangle destR = new Rectangle(Position.X, Position.Y, DiamondImage.Width, DiamondImage.Height);
			Rectangle srcR = new Rectangle(0,0, DiamondImage.Width, DiamondImage.Height);
			g.DrawImage(DiamondImage, destR, srcR, GraphicsUnit.Pixel);
		}
	}
}
