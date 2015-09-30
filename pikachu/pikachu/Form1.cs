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

         /*  pictureBox1.Visible = true;
            pictureBox2.Visible = false;*/

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = pictureBox2.Visible == true ? false : true;

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
