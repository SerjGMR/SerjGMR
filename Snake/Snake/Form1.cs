using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Food food1;


        private Graphics graphics;

        private Snake snake;
        private Bitmap bitmap;
        private int score;
        private void Form1_Load(object sender, EventArgs e)
        {
            snake = new Snake(24, 0, true, Color.Orange, 47, true);
            bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
            score = 0;
            graphics = Graphics.FromImage(bitmap);
            food1 = new Food(0, 0, Color.Red, 21, 21);
            food1.Move();

        
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                snake.Turn("Up");
            }
            if (e.KeyCode == Keys.S)
            {
                snake.Turn("Down");
            }
            if (e.KeyCode == Keys.A)
            {
                snake.Turn("Left");
            }
            if (e.KeyCode == Keys.D)
            {
                snake.Turn("Right");
            }
        }

        private void Move_Tick(object sender, EventArgs e)
        {
            snake.Update(ClientRectangle, 
                        new Rectangle(LeftBoundary.Location,LeftBoundary.Size), 
                        new Rectangle(RightBoundary.Location, RightBoundary.Size),
                        new Rectangle(BottomBoundary.Location, BottomBoundary.Size));
        }

        private void Reset_Tick(object sender, EventArgs e)
        {
            if (snake.getHitBox(0).IntersectsWith(food1.getHitBox()))
            {
                food1.Move();
                snake.addBodyPart();
            }
            graphics.Clear(Color.Transparent);
            snake.Draw(graphics: graphics);
            food1.Draw(graphics);
            Background.Image = bitmap;
            if (snake.Alive() == false)
            {
                test.Visible = true;
            }
        }

    }
}
