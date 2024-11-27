using System.Numerics;
using System.Windows.Forms;

namespace tictactoe
{


    public partial class Form1 : Form
    {
        char[] grid = new char[9];
        char playerturn = 'o';
        bool gameover = false;

        bool horizontalwin()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (grid[i] == playerturn && grid[i + 1] == playerturn && grid[i + 2] == playerturn)
                {
                    return true;
                }
            }
            return false;
        }

        bool verticalwin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (grid[i] == playerturn && grid[i + 3] == playerturn && grid[i + 6] == playerturn) { return true; }
            }
            return false;
        }

        bool diagonalwin()
        {
            if (grid[0] == playerturn && grid[4] == playerturn && grid[8] == playerturn) { return true; }
            if (grid[2] == playerturn && grid[4] == playerturn && grid[6] == playerturn) { return true; }

            return false;
        }
        bool checkforwin()
        {
            if (verticalwin()) { return true; }
            if (horizontalwin()) { return true; }
            if (diagonalwin()) { return true; }
            return false;
        }

        bool draw()
        {
            foreach (char x in grid)
            {
                if (x == ' ') { return false; }
            }
            return true;
        }
        bool game(PictureBox pictureBox, int num)
        {
            grid[num] = playerturn;
            if (playerturn == 'o')
            {
                pictureBox.Image = Image.FromFile("o.png");
                pictureBox.BorderStyle = BorderStyle.None;
            }
            else
            {
                pictureBox.Image = Image.FromFile("x.png");
                pictureBox.BorderStyle = BorderStyle.None;
            }

            if (checkforwin())
            {
                if (playerturn == 'o')
                {
                    label3.Text = "player " + '1' + " wins!";
                    //restart?
                    return false;
                }
                else
                {
                    label3.Text = "player " + '2' + " wins!";
                    //restart?
                    return false;
                }
            }
            else
            {
                if (draw())
                {
                    label3.Text = "draw";
                    return false;
                }
                if (playerturn == 'o')
                {

                    playerturn = 'x';
                    label3.Text = "player 2 turn";

                }
                else
                {
                    playerturn = 'o';
                    label3.Text = "player 1 turn";
                }
            }
            return true;

        }


       
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = ' ';
            }
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(gameover == false)
            {
                if (this.pictureBox1.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox1, 0))
                    {
                        gameover = true;
                    }
                }

            }
            else
            {
               button1_Click(sender, e);
                game(pictureBox1, 0);
                gameover = false;
            }
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (gameover == false)
            {

                if (this.pictureBox2.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox2, 1))
                    {
                        gameover = true;
                    }
                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox2, 1);
                gameover = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           if( gameover == false)
            {
                if (this.pictureBox3.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox3, 2))
                    {
                        gameover = true;
                    }

                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox3, 2);
                gameover = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {
                if (this.pictureBox4.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox4, 3))
                    {
                        gameover = true;
                    }

                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox4, 3);
                gameover = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           if(!gameover)
            {
                if (this.pictureBox5.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox5, 4)) { gameover = true; }
                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox5, 4);
                gameover = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {

                if (this.pictureBox6.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox6, 5)) { gameover = true; }

                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox6, 5);
                gameover = false;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {
                if (this.pictureBox7.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox7, 6)) { gameover = true; }

                }

            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox7, 6);
                gameover = false;
            }
          
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {
                if (this.pictureBox8.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox8, 7)) { gameover = true; }

                }

            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox8, 7);
                gameover = false;
            }
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (!gameover)
            {
                if (this.pictureBox9.Image != null)
                {
                    label3.Text = "pick an empty square";
                }
                else
                {
                    if (!game(pictureBox9, 8)) { gameover = true; }
                }
            }
            else
            {
                button1_Click(sender, e);
                game(pictureBox9, 8);
                gameover = false;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                grid[i] = ' ';
            }
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            playerturn = 'o';
            label3.Text = "player 1 turn";
        }
    }
}
