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


            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);






        }
        private void Form1_KeyDown(object sender, KeyEventArgs ev)
        {

            x = pictureBox1.Location.X;
            y = pictureBox1.Location.Y;
            if (ev.KeyCode == Keys.Right) x += 5;
            else if (ev.KeyCode == Keys.Left) x -= 5;
            else if (ev.KeyCode == Keys.Up) y -= 5;
            else if (ev.KeyCode == Keys.Down) y += 5;
            if (!pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))

            {
             
            }
            label1.Text = x.ToString() + " " + y.ToString();
            pictureBox1.Location = new Point(x, y);







        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
