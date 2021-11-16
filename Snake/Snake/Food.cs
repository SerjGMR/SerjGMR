using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Food
    {
        private int x;
        private int y;
        private int width;
        private int height;
        private Random rand;

        private Brush color;
        public Food(int X, int Y, Color color, int Width, int Height)
        {
            x = X;
            y = Y;
            rand = new Random();
            width = Width;
            height = Height;
            this.color = new SolidBrush(color);
        }

        public Rectangle getHitBox()
        {
            return new Rectangle(x, y, width, height);
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void Move()
        {
            x = (rand.Next(0, 12) * 47) + 37;
            y = (rand.Next(0, 7) * 47) + 13;
        }
        public int getWidth()
        {
            return width;
        }

        public int getHeight()
        {
            return height;
        }
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(color, x, y, width, height);
        }
    }
}
