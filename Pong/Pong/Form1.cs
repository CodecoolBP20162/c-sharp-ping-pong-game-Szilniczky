using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public int speedLeft = 4;
        public int speedTop = 4;
        public int score = 0;

        public Form1()
        {
            InitializeComponent();
            
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            gameover.Left = (playground.Width / 2) - (gameover.Width / 2);
            gameover.Top = (playground.Height / 2) - (gameover.Height / 2);
            gameover.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speedLeft;
            ball.Top += speedTop;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                /*speedTop += 2;
                speedLeft += 2;*/
                speedTop = -speedTop;
                score += 1;
                scoreNumber.Text = score.ToString();

                Random color = new Random();
                playground.BackColor = Color.FromArgb(color.Next(150, 255), color.Next(150, 255), color.Next(150, 255));
            }

            if (ball.Left <= playground.Left)
            {
                speedLeft = -speedLeft;
            }

            if (ball.Right >= playground.Right)
            {
                speedLeft = -speedLeft;
            }

            if (ball.Top <= playground.Top)
            {
                speedTop = -speedTop;
            }
            
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled == true)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
            }

            if (e.KeyCode == Keys.Enter)
            {
                ball.Left = 50;
                ball.Top = 50;
                speedLeft = 4;
                speedTop = 4;
                score = 0;
                scoreNumber.Text = "0";
                timer1.Enabled = true;
                gameover.Visible = false;
                playground.BackColor = Color.White;
            }
        }
    }
}
