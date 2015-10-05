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
            pictureBox29.Visible = false;
           
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
            int beersX = 32;
            int beersY =20;
            int lightningX = 0;
            int lightningY = 0;
            PictureBox[] walls = { pictureBox6, pictureBox3, pictureBox7, pictureBox8, pictureBox5, pictureBox9, pictureBox12, pictureBox13, pictureBox20, pictureBox28, pictureBox26, pictureBox25, pictureBox24, pictureBox23, pictureBox11, pictureBox14, pictureBox10, pictureBox31, pictureBox30, pictureBox27 };
            PictureBox[] beers = { pictureBox15, pictureBox16, pictureBox17 };
            PictureBox[] win = { pictureBox18, pictureBox19 };
            PictureBox[] monsters = { pictureBox21, pictureBox22, pictureBox4 };
            PictureBox[] lightning = { pictureBox32, pictureBox33, pictureBox34, pictureBox35, pictureBox36, pictureBox37, pictureBox38, pictureBox39, pictureBox40, pictureBox41, pictureBox42, pictureBox43, pictureBox44, pictureBox45, pictureBox46, pictureBox47, pictureBox48, pictureBox49, pictureBox50, pictureBox51, pictureBox52, pictureBox53,  pictureBox54,  pictureBox55,  pictureBox56,  pictureBox57, pictureBox58,  pictureBox59,  pictureBox60,  pictureBox61, pictureBox62, pictureBox63, pictureBox64, pictureBox65, pictureBox66};
        PictureBox gameOver =  pictureBox29;

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
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
                for (int i = 0; i < beers.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(beers[i].Bounds))
                    {
                        beers[i].Location = new Point(beersX, beersY);
                        beersX += 50;
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(monsters[i].Bounds))
                    {
                        pictureBox29.Visible = true;
                    }

                }
                for (int i = 0; i < lightning.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(lightning[i].Bounds))
                    {


                        lightning[i].Location = new Point(lightningX, lightningY);

                        pictureBox1.Location = new Point(x, y);
                        pictureBox2.Location = new Point(x, y);

                    }

                }
                for (int i = 0; i < win.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(win[i].Bounds))
                    {


                        GogoHeroLevel(walls, beers, monsters, win);

                    }

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
                for (int i = 0; i < beers.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(beers[i].Bounds))
                    {
                        
                        beersX += 50;
                        beers[i].Location = new Point(beersX, beersY);
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(monsters[i].Bounds))
                    {
                        pictureBox29.Visible = true;
                       
                    }

                }
                for (int i = 0; i < lightning.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(lightning[i].Bounds))
                    {


                        lightning[i].Location = new Point(lightningX, lightningY);
                        
                        pictureBox1.Location = new Point(x, y);
                        pictureBox2.Location = new Point(x, y);

                    }

                }
                for (int i = 0; i < lightning.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(lightning[i].Bounds))
                    {


                        lightning[i].Location = new Point(lightningX, lightningY);

                        pictureBox1.Location = new Point(x, y);
                        pictureBox2.Location = new Point(x, y);

                    }

                }
                for (int i = 0; i < win.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(win[i].Bounds))
                    {


                        GogoHeroLevel(walls, beers, monsters, win);

                    }

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
                for (int i = 0; i < beers.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(beers[i].Bounds))
                    {
                        beersX += 50;
                        beers[i].Location = new Point(beersX, beersY);
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(monsters[i].Bounds))
                    {
                        pictureBox29.Visible = true;
                        
                    }

                }
                for (int i = 0; i < lightning.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(lightning[i].Bounds))
                    {


                        lightning[i].Location = new Point(lightningX, lightningY);

                        pictureBox1.Location = new Point(x, y);
                        pictureBox2.Location = new Point(x, y);

                    }

                }
                for (int i = 0; i < win.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(win[i].Bounds))
                    {


                        GogoHeroLevel(walls, beers, monsters, win);

                    }

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
                for (int i = 0; i < beers.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(beers[i].Bounds))
                    {
                        beersX += 50;
                        beers[i].Location = new Point(beersX, beersY);
                    }
                    pictureBox1.Location = new Point(x, y);
                    pictureBox2.Location = new Point(x, y);
                }
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(monsters[i].Bounds))
                    {
                        pictureBox29.Visible = true;
                        
                    }

                }
                for (int i = 0; i < lightning.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(lightning[i].Bounds))
                    {


                        lightning[i].Location = new Point(lightningX, lightningY);

                        pictureBox1.Location = new Point(x, y);
                        pictureBox2.Location = new Point(x, y);

                    }

                }
                for (int i = 0; i < win.Length; i++)
                {
                    if (pictureBox1.Bounds.IntersectsWith(win[i].Bounds))
                    {


                        GogoHeroLevel(walls, beers, monsters, win);

                    }

                }

            }


        }

        private void GogoHeroLevel(PictureBox[] walls, PictureBox[] beers, PictureBox[] monsters, PictureBox[] win)
        {
            int x =0, y = 0;
            
           walls[0].Location = new Point(x, y);
        }

        private void Enemy()
        {

            int x = pictureBox21.Location.X;
            int y = pictureBox21.Location.Y;
            pictureBox21.Location = new Point(x, y);
        
        label2.Text = (pictureBox21.Location.Y).ToString();

            if (!pictureBox21.Bounds.IntersectsWith(pictureBox8.Bounds))
            {

                    x += 1;
                    pictureBox21.Location = new Point(x, y);
                    label2.Text = (pictureBox21.Location.Y).ToString();

               
            }
            else
            {
                while (x>10)
                {
                    x -= 1;
                    pictureBox21.Location = new Point(x, y);
                    label2.Text = (pictureBox21.Location.Y).ToString();
                }
              
            }
            int x1 = pictureBox22.Location.X;
            int y1 = pictureBox22.Location.Y;
            pictureBox22.Location = new Point(x1, y1);

            label2.Text = (pictureBox22.Location.Y).ToString();

            if (!pictureBox22.Bounds.IntersectsWith(pictureBox5.Bounds))
            {

                x1-= 1;
                pictureBox22.Location = new Point(x1, y1);
                label2.Text = (pictureBox21.Location.Y).ToString();


            }
            else 
            {

                while (!pictureBox22.Bounds.IntersectsWith(pictureBox26.Bounds))
                {
                    x1 += 1;
                    pictureBox22.Location = new Point(x1, y1);
                    label2.Text = (pictureBox21.Location.Y).ToString();
                }

            }
            int x2 = pictureBox4.Location.X;
            int y2 = pictureBox4.Location.Y;
            pictureBox4.Location = new Point(x2, y2);

            label2.Text = (pictureBox4.Location.Y).ToString();

            if (!pictureBox4.Bounds.IntersectsWith(pictureBox11.Bounds))
            {

                y2+= 1;
                pictureBox4.Location = new Point(x2, y2);
                label2.Text = (pictureBox4.Location.Y).ToString();


            }
            else
            {

                while (!pictureBox4.Bounds.IntersectsWith(pictureBox28.Bounds))
                {
                    y2 -= 1;
                    pictureBox4.Location = new Point(x2, y2);
                   
                }

            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

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
