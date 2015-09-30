using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pikachu
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = pictureBox2.Visible == true ? false : true;

        }
        private void Form1_KeyDown(object sender, KeyEventArgs ev)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int x1 = pictureBox2.Location.X;
            int y1 = pictureBox2.Location.Y;

            if (ev.KeyCode == Keys.Right)
            {

                x += 5;
                x1 += 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                timer1.Enabled = true;
              //  
                if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    x -= 5;
                    x1 -= 5;
                    timer1.Enabled = false;
                }
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
               // timer1.Enabled = false;

            }
            else if (ev.KeyCode == Keys.Left)
            {

                x -= 5;
                x1 -= 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    x += 5;
                    x1 += 5;
                }
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
            }
            else if (ev.KeyCode == Keys.Up)
            {
                y -= 5;
                y1 -= 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    y += 5;
                    y1 += 5;
                }
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
            }

            else if (ev.KeyCode == Keys.Down)
            {
                y += 5;
                y1 += 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
                {
                    y -= 5;
                    y1 -= 5;
                }
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
            }
            


        }


    }
    public class Charapter
    {
        PictureBox[] charapter;
        int x, y;
        public Charapter(PictureBox[] charapter, int x, int y)
        {
            this.charapter = charapter;
            this.x = x;
            this.y = y;
        }
        public PictureBox ViewNext(int i)
        {
            return charapter[i];
        }
    }
    public class Wall
    {
        PictureBox wall;
        int x, y;
        public Wall(PictureBox wall, int x, int y)
        {
            this.wall = wall;
            this.x = x;
            this.y = y;
        }

    }
}
