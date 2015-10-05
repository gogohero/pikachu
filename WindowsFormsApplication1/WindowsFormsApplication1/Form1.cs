using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static int x;
        static int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
=======


            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);






>>>>>>> 96d1c03041a3040ab1d4430c56d0af14d7350d27
        }
        private void Form1_KeyDown(object sender, KeyEventArgs ev)
        {
            x = pictureBox1.Location.X;
<<<<<<< HEAD
            y = pictureBox1.Location.Y;
            if (ev.KeyCode == Keys.Right) x += 5;
            else if (ev.KeyCode == Keys.Left) x -= 5;
            else if (ev.KeyCode == Keys.Up) y -= 5;
            else if (ev.KeyCode == Keys.Down) y += 5;
            if (pictureBox1 == pictureBox2)
            {
                
            }
            label1.Text = x.ToString() + " " + y.ToString();
            pictureBox1.Location = new Point(x, y);
        }
=======
            y = pictureBox1.Location.Y;


            if (ev.KeyCode == Keys.Right)
            {

                x += 5;
                pictureBox1.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    x -= 5;
                }
                pictureBox1.Location = new Point(x, y);
            }
            else if (ev.KeyCode == Keys.Left)
            {

                x -= 5;
                pictureBox1.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    x += 5;
                }
                pictureBox1.Location = new Point(x, y);
            }
            else if (ev.KeyCode == Keys.Up)
            {
                y -= 5; pictureBox1.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    y += 5;
                }
                pictureBox1.Location = new Point(x, y);
            }

            else if (ev.KeyCode == Keys.Down)
            {
                y += 5;
                pictureBox1.Location = new Point(x, y);
                if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
                {
                    y -= 5;
                }
                pictureBox1.Location = new Point(x, y);
            }



        }
       
>>>>>>> 96d1c03041a3040ab1d4430c56d0af14d7350d27
    }
}
