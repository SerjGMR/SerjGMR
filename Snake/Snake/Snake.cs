using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    class Snake
    {
        private List<BodyPart> Parts;
        private bool alive;
        public Snake(int x,  int y, bool front, Color color, int speed, bool alive)
        {
            Parts = new List<BodyPart>();
            Parts.Add(new BodyPart(x, y, front, color, speed, ""));
            this.alive = alive;
        }
        public BodyPart GetHead()
        {
            return Parts[0];
        }
        private BodyPart GetTail()
        {
            return Parts[Parts.Count - 1];
        }

        public bool Alive()
        {
            return alive;
        }
        //how to move snake
        //go from back to front
        //set each piece's location to the piece before it

        public void Update(Rectangle client, Rectangle left, Rectangle right, Rectangle bottom)
        {
            for (int a = Parts.Count - 1; a > 0; a--)
            {
                Parts[a].move(Parts[a-1].getX(), Parts[a-1].getY());
            }
            Parts[0].Update(Parts[0].Direction, client, left, right, bottom);
            if (Parts[0].Direction == "Right" && GetHead().getX() > client.Width - (GetHead().getSpeed() + right.Width))
            {
                Parts[0].move(client.Width - (GetHead().getSpeed() + right.Width - 1), GetHead().getY());
            }
            if (Parts[0].Direction == "Left" && GetHead().getX() < left.Width)
            {
                Parts[0].move(22, GetHead().getY());
            }
            if (Parts[0].Direction == "Down" && GetHead().getY() + GetHead().getSpeed() > client.Height - bottom.Height)
            {
                Parts[0].move(GetHead().getX(), client.Height - (GetHead().getSpeed() + bottom.Height - 1));
            }
            for (int b = 1; b < Parts.Count; b++)
            {
                if (Parts[0].getHitBox().IntersectsWith(Parts[b].getHitBox()))
                {
                    alive = false;
                }
            }
        }
        public void Draw(Graphics graphics)
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                Parts[i].Draw(graphics);
            }
        }
        public Rectangle getHitBox(int bodypart)
        {
            return Parts[bodypart].getHitBox();
        }
        public void addBodyPart()
        {
           
            BodyPart newPiece = new BodyPart(GetTail());
            if (newPiece.Direction == "Up")
            {
                newPiece.MoveLocation(0, Parts[0].getSpeed());
            }
           else if (newPiece.Direction == "Down")
            {
                newPiece.MoveLocation(0, -Parts[0].getSpeed());
            }
           else if (newPiece.Direction == "Left")
            {
                newPiece.MoveLocation(Parts[0].getSpeed(), 0);
            }
           else if (newPiece.Direction == "Right")
            {
                newPiece.MoveLocation(-Parts[0].getSpeed(), 0);
            }
            Parts.Add(newPiece);
        }
        public void Turn(string Direction)
        {
            Parts[0].Direction = Direction;
        }
    }
}
