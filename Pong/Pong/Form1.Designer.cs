namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground = new System.Windows.Forms.Panel();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(284, 261);
            this.playground.TabIndex = 0;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.SystemColors.HotTrack;
            this.racket.Location = new System.Drawing.Point(68, 208);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(147, 21);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(110, 102);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(21, 21);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
    }
}

