using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Enemy();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs ev)
        {

            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;
            int x1 = pictureBox2.Location.X;
            int y1 = pictureBox2.Location.Y;
            PictureBox[] walls = { pictureBox6, pictureBox3, pictureBox7, pictureBox8, pictureBox5, pictureBox9, pictureBox12, pictureBox13, pictureBox20, pictureBox28, pictureBox27, pictureBox26, pictureBox25, pictureBox24, pictureBox23, pictureBox11, pictureBox14, pictureBox10 };

            if (ev.KeyCode == Keys.Right)
            {

                x += 5;
                x1 += 10;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                pictureBox1.Image = Image.FromFile("../../Resources/6.png");
                pictureBox2.Image = Image.FromFile("../../Resources/7.png");
                pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
                for (int i = 0; i < walls.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        x -= 10;
                        x1 -= 10;
                        timer1.Enabled = false;
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }

            }

            else if (ev.KeyCode == Keys.Left)
            {

                x -= 5;
                x1 -= 5;
                // pictureBox1.
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                pictureBox1.Image = Image.FromFile("../../Resources/6.2.png");
                pictureBox2.Image = Image.FromFile("../../Resources/7.2.png");
                pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
                for (int i = 0; i < walls.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        x += 5;
                        x1 += 5;
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
            }
            else if (ev.KeyCode == Keys.Up)
            {
                y -= 5;
                y1 -= 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                pictureBox1.Image = Image.FromFile("../../Resources/6.3.png");
                pictureBox2.Image = Image.FromFile("../../Resources/7.3.png");
                pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
                for (int i = 0; i < walls.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        y += 5;
                        y1 += 5;
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
            }

            else if (ev.KeyCode == Keys.Down)
            {
                y += 5;
                y1 += 5;
                pictureBox1.Location = new Point(x, y);
                pictureBox2.Location = new Point(x, y);
                pictureBox1.Image = Image.FromFile("../../Resources/6.4.png");
                pictureBox2.Image = Image.FromFile("../../Resources/7.4.png");
                pictureBox2.Visible = pictureBox2.Visible == true ? false : true;
                for (int i = 0; i < walls.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(walls[i].Bounds))
                    {
                        y -= 5;
                        y1 -= 5;
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
            }


        }
        private void Enemy()
        {
            int x = pictureBox4.Location.X;
            int y = 300;


            pictureBox4.Location = new Point(x, y);
            label2.Text = (pictureBox4.Location.Y).ToString();
            if (!pictureBox4.Bounds.IntersectsWith(pictureBox3.Bounds))
            {


                while (y > 0)
                {
                    y -= 1;
                    pictureBox4.Location = new Point(x, y);
                    label2.Text = (pictureBox4.Location.Y).ToString();

                }
                /* while (y < 300)
                 {
                     y += 5;
                     pictureBox4.Location = new Point(x, y);
                     label2.Text = (pictureBox4.Location.Y).ToString();

                 }*/
            }
            int x2 = pictureBox4.Location.X;
            int y2 = pictureBox4.Location.Y;
            pictureBox21.Location = new Point(x, y);
        
        label2.Text = (pictureBox21.Location.Y).ToString();

            if (!pictureBox21.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                while (x > 0)
                {
                    x -= 1;
                    pictureBox21.Location = new Point(x, y);
                    label2.Text = (pictureBox4.Location.Y).ToString();

                }
               
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
