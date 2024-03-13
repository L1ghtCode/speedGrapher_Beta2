using System.Windows.Forms;

namespace speedGrapher_Beta2
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelCombo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelRestart = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelChangeLvl = new System.Windows.Forms.Label();
            this.labelLive = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 24.25F);
            this.textBox1.Location = new System.Drawing.Point(265, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(640, 45);
            this.textBox1.TabIndex = 0;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(35, 320);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(98, 30);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Очки: 0";
            // 
            // labelSong
            // 
            this.labelSong.AutoSize = true;
            this.labelSong.BackColor = System.Drawing.Color.Transparent;
            this.labelSong.Font = new System.Drawing.Font("Cambria", 24.25F);
            this.labelSong.ForeColor = System.Drawing.Color.White;
            this.labelSong.Location = new System.Drawing.Point(258, 31);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(87, 38);
            this.labelSong.TabIndex = 2;
            this.labelSong.Text = "hello";
            // 
            // labelCombo
            // 
            this.labelCombo.AutoSize = true;
            this.labelCombo.BackColor = System.Drawing.Color.Transparent;
            this.labelCombo.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelCombo.ForeColor = System.Drawing.Color.White;
            this.labelCombo.Location = new System.Drawing.Point(35, 360);
            this.labelCombo.Name = "labelCombo";
            this.labelCombo.Size = new System.Drawing.Size(118, 30);
            this.labelCombo.TabIndex = 3;
            this.labelCombo.Text = "Комбо:  0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(35, 400);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(117, 30);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Время:  0";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.BackColor = System.Drawing.Color.Transparent;
            this.labelStart.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelStart.ForeColor = System.Drawing.Color.White;
            this.labelStart.Location = new System.Drawing.Point(40, 40);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(79, 30);
            this.labelStart.TabIndex = 9;
            this.labelStart.Text = "Старт";
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            this.labelStart.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelStart.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(265, 190);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(640, 360);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // labelRestart
            // 
            this.labelRestart.AutoSize = true;
            this.labelRestart.BackColor = System.Drawing.Color.Transparent;
            this.labelRestart.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelRestart.ForeColor = System.Drawing.Color.White;
            this.labelRestart.Location = new System.Drawing.Point(40, 150);
            this.labelRestart.Name = "labelRestart";
            this.labelRestart.Size = new System.Drawing.Size(102, 30);
            this.labelRestart.TabIndex = 11;
            this.labelRestart.Text = "Рестарт";
            this.labelRestart.Click += new System.EventHandler(this.labelRestart_Click);
            this.labelRestart.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelRestart.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(40, 220);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(84, 30);
            this.labelExit.TabIndex = 12;
            this.labelExit.Text = "Выход";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelExit.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // labelChangeLvl
            // 
            this.labelChangeLvl.AutoSize = true;
            this.labelChangeLvl.BackColor = System.Drawing.Color.Transparent;
            this.labelChangeLvl.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelChangeLvl.ForeColor = System.Drawing.Color.White;
            this.labelChangeLvl.Location = new System.Drawing.Point(40, 110);
            this.labelChangeLvl.Name = "labelChangeLvl";
            this.labelChangeLvl.Size = new System.Drawing.Size(126, 30);
            this.labelChangeLvl.TabIndex = 13;
            this.labelChangeLvl.Text = "Изменить";
            this.labelChangeLvl.Click += new System.EventHandler(this.labelChangeLvl_Click);
            this.labelChangeLvl.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelChangeLvl.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // labelLive
            // 
            this.labelLive.AutoSize = true;
            this.labelLive.BackColor = System.Drawing.Color.Transparent;
            this.labelLive.Font = new System.Drawing.Font("Cambria", 18.25F);
            this.labelLive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelLive.Location = new System.Drawing.Point(935, 520);
            this.labelLive.Name = "labelLive";
            this.labelLive.Size = new System.Drawing.Size(25, 30);
            this.labelLive.TabIndex = 14;
            this.labelLive.Text = "x";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::speedGrapher_Beta2.Properties.Resources.pixelHeart;
            this.pictureBox1.Location = new System.Drawing.Point(910, 520);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::speedGrapher_Beta2.Properties.Resources.black;
            this.ClientSize = new System.Drawing.Size(1184, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelLive);
            this.Controls.Add(this.labelChangeLvl);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelRestart);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCombo);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Ожидание начала игры";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal TextBox textBox1;
        private Label labelScore;
        private Label labelSong;
        private Label labelCombo;
        private System.Windows.Forms.Timer timer1;
        private Label labelTime;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label labelStart;
        private Label labelRestart;
        private Label labelExit;
        private Label labelChangeLvl;
        private Label labelLive;
        private PictureBox pictureBox1;
    }
}