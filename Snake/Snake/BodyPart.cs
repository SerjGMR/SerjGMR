using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class BodyPart
    {
        private int speed;
        private int x;
        private int y;
        private bool front;
        public string Direction;

        private Brush color;

        public BodyPart(int X, int Y, bool Front, Color color, int Speed, string Direction)
        {
            x = X;
            y = Y;
            front = Front;
            this.color = new SolidBrush(color);
            speed = Speed;
            this.Direction = Direction;
        }

        public BodyPart(BodyPart partToCopy)
        {
            x = partToCopy.x;
            y = partToCopy.y;
            front = partToCopy.front;
            color = partToCopy.color;
            speed = partToCopy.speed;
            Direction = partToCopy.Direction;
            
        }

        public Rectangle getHitBox()
        {
            return new Rectangle(x, y, speed, speed);
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void move(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public bool isFront()
        {
            return front;
        }
        public void MoveLocation(int xAmount, int yAmount)
        {
            x += xAmount;
            y += yAmount;
        }
        private void Move(Rectangle client, Rectangle left, Rectangle right, Rectangle bottom)
        {
            if (Direction == "Up" && y >= speed)
            {
                y -= speed;
            }
            if (Direction == "Down" && y <= client.Height - (speed + bottom.Height))
            {
                y += speed;
            }
            if (Direction == "Left" && x >= left.Width)
            {
                x -= speed;
            }
            if (Direction == "Right" && x <= client.Width - (speed + right.Width))
            {
                x += speed;
            }
        }

        public void Update(string direction, Rectangle client, Rectangle left, Rectangle right, Rectangle bottom)
        {
            Move(client, left, right, bottom);
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(color,x,y,speed,speed);
        }   
        public int getSpeed()
        {
            return speed;
        }
        public string getDirection()
        {
            return Direction;
        }
    }
}