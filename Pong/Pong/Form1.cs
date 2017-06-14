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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speedLeft;
            ball.Top += speedTop;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speedTop += 2;
                speedLeft += 2;
                speedTop = -speedTop;
                score += 1;
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
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
