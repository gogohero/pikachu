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
    public partial class Level2 : Form
    {
    
        bool right;
        bool left;
        bool top;
        bool bottom;
       
       
        public Level2()
        {
            
            InitializeComponent();

        }



        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; Player.Image = Image.FromFile("RunningRight.gif"); }
            if (e.KeyCode == Keys.Left) { left = true; Player.Image = Image.FromFile("RunningLeft.gif"); }
            if (e.KeyCode == Keys.Up) { top = true; Player.Image = Image.FromFile("RunningUp.png"); }
            if (e.KeyCode == Keys.Down) { bottom = true; Player.Image = Image.FromFile("RunningDown.png"); }

        }

        private void Level2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; Player.Image = Image.FromFile("10.png"); }
            if (e.KeyCode == Keys.Left) { left = false; Player.Image = Image.FromFile("10.png"); }
            if (e.KeyCode == Keys.Up) { top = false; Player.Image = Image.FromFile("10.png"); }
            if (e.KeyCode == Keys.Down) { bottom = false; Player.Image = Image.FromFile("10.png"); }


        }
    
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            //Bordercollision 
            if(Player.Top<=screen.Top)
            {
                top = false;
            }
            if (Player.Left <= screen.Left)
            {
                left = false;
            }
            if (Player.Right >= screen.Right)
            {
                right = false;
            }
            if (Player.Bottom >= screen.Bottom)
            {
                bottom = false;
            }


            //BordercollisionEnd
            
            
            // DownMovingWalls
            if (wall1.Top >= screen.Bottom)
            {
                wall1.Top -= 500;
            }
            if (wall2.Top >= screen.Bottom)
            {
                wall2.Top -= 500;
            }
            if (wall3.Top >= screen.Bottom)
            {
                wall3.Top -= 500;
            }
            if (wall4.Top >= screen.Bottom)
            {
                wall4.Top -= 500;
            }
           
            wall1.Top += 5;
            wall2.Top += 5;
            wall3.Top += 5;
            wall4.Top += 5;
          //DownMovingWallsEnd
          
            //UpMovingWalls
            
            if (UpMovWall2.Top <= screen.Top-150)
            {
                UpMovWall2.Top += 600;
            }
            if (UpMovWall3.Top <= screen.Top-150)
            {
                UpMovWall3.Top += 600;
            }
            if (UpMovWall4.Top <= screen.Top-150)
            {
                UpMovWall4.Top += 600;
            }
            if (UpMovWall5.Top <= screen.Top - 150)
            {
                UpMovWall5.Top += 600;
            }

            
            UpMovWall2.Top -= 5;
            UpMovWall3.Top -= 5;
            UpMovWall4.Top -= 5;
            UpMovWall5.Top -= 5;
            //UpMovingWallsEnd
            

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Colision(innerwall1);
            Colision(innerwall2);
            Colision(innerwall3);
            Colision(innerwall4);
            Colision(innerwall5);
            Colision(innerwall6);
            Colision(innerwall7);
            GameOverColision(wall1);
            GameOverColision(wall2);
            GameOverColision(wall3);
            
            GameOverColision(UpMovWall2);
            GameOverColision(UpMovWall3);
            GameOverColision(UpMovWall4);
            GameOverColision(UpMovWall5);
            BeerColision(beer1);
            BeerColision(beer2);
            BeerColision(beer3);
            BeerColision(beer4);
            BeerColision(beer5);
            BeerColision(beer7);
            
            //innerWallCollisonEnd
            

            if (right == true) { Player.Left += 5; }
            if (left == true) { Player.Left -= 5; }
            if (top == true) { Player.Top -= 5; }
            if (bottom == true) { Player.Top += 5; }
        }
       public void Colision(PictureBox wal)
       {
           if (Player.Right > wal.Left && Player.Left < wal.Right - Player.Width / 2 && Player.Bottom > wal.Top && Player.Top<wal.Bottom) { right = false; }
           if (Player.Left < wal.Right && Player.Right > wal.Left + Player.Width / 2 && Player.Bottom > wal.Top && Player.Top < wal.Bottom) { left = false; }
           if (Player.Bottom+5 >= wal.Top && Player.Top < wal.Top - Player.Height / 2 && Player.Right-2 > wal.Left && Player.Left+5<wal.Right) { bottom = false; }
           if (Player.Top - 5 <= wal.Bottom && Player.Bottom > wal.Bottom - Player.Height / 2 && Player.Right - 2 > wal.Left && Player.Left + 5 < wal.Right) { top = false; }
       }
       public void GameOverColision(PictureBox wal)
       {
           if (Player.Right > wal.Left && Player.Left < wal.Right - Player.Width / 2 && Player.Bottom > wal.Top && Player.Top < wal.Bottom) { GameOver(); }
           if (Player.Left < wal.Right && Player.Right > wal.Left + Player.Width / 2 && Player.Bottom > wal.Top && Player.Top < wal.Bottom) { GameOver(); }
           if (Player.Bottom + 5 >= wal.Top && Player.Top < wal.Top - Player.Height / 2 && Player.Right - 2 > wal.Left && Player.Left + 5 < wal.Right) { GameOver(); }
           if (Player.Top - 5 <= wal.Bottom && Player.Bottom > wal.Bottom - Player.Height / 2 && Player.Right - 2 > wal.Left && Player.Left + 5 < wal.Right) { GameOver();  }
       }
       public void BeerColision(PictureBox wal)
       {
           if (Player.Right > wal.Left && Player.Left < wal.Right - Player.Width / 2 && Player.Bottom > wal.Top && Player.Top < wal.Bottom) { wal.Hide();   }
           if (Player.Left < wal.Right && Player.Right > wal.Left + Player.Width / 2 && Player.Bottom > wal.Top && Player.Top < wal.Bottom) { wal.Hide();   }
           if (Player.Bottom + 5 >= wal.Top && Player.Top < wal.Top - Player.Height / 2 && Player.Right - 2 > wal.Left && Player.Left + 5 < wal.Right) { wal.Hide(); }
           if (Player.Top - 5 <= wal.Bottom && Player.Bottom > wal.Bottom - Player.Height / 2 && Player.Right - 2 > wal.Left && Player.Left + 5 < wal.Right) { wal.Hide();   }
       }

       public void GameOver()
       {
           Level2 form2 = new Level2();
           form2.Show();
           this.Close();  
       }
       public void DieColision(PictureBox wall)
       {
          
       }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Level2_Load(object sender, EventArgs e)
        {

        }

        private void wall4_Click(object sender, EventArgs e)
        {

        }

        private void wall3_Click(object sender, EventArgs e)
        {

        }

        private void wall5_Click(object sender, EventArgs e)
        {

        }

        private void Player_Click(object sender, EventArgs e)
        {

        }
        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Level2_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void outterwall3_Click(object sender, EventArgs e)
        {

        }

        private void innerwall4_Click(object sender, EventArgs e)
        {
            Level2 form2 = new Level2();
            form2.Show();
            this.Close();  
        }

        private void wall2_Click(object sender, EventArgs e)
        {

        }

        private void UpMovWall2_Click(object sender, EventArgs e)
        {

        }

        private void innerwall6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

       
    }
}
