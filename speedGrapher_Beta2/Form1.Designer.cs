namespace speedGrapher_Beta2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.autoSpace = new System.Windows.Forms.CheckBox();
            this.l3 = new System.Windows.Forms.Label();
            this.nudLive = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudVolume = new System.Windows.Forms.NumericUpDown();
            this.labelMain = new System.Windows.Forms.Label();
            this.lExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.BackColor = System.Drawing.Color.Transparent;
            this.l1.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.l1.ForeColor = System.Drawing.Color.White;
            this.l1.Location = new System.Drawing.Point(40, 40);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(96, 22);
            this.l1.TabIndex = 0;
            this.l1.Text = "Уровень 1";
            this.l1.Visible = false;
            this.l1.Click += new System.EventHandler(this.l1_Click);
            this.l1.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.l1.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.BackColor = System.Drawing.Color.Transparent;
            this.l2.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.l2.ForeColor = System.Drawing.Color.White;
            this.l2.Location = new System.Drawing.Point(40, 70);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(96, 22);
            this.l2.TabIndex = 1;
            this.l2.Text = "Уровень 2";
            this.l2.Visible = false;
            this.l2.Click += new System.EventHandler(this.l2_Click);
            this.l2.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.l2.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(44, 210);
            this.nudSpeed.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 24);
            this.nudSpeed.TabIndex = 10;
            this.nudSpeed.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSpeed.Visible = false;
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // autoSpace
            // 
            this.autoSpace.AutoSize = true;
            this.autoSpace.BackColor = System.Drawing.Color.Transparent;
            this.autoSpace.Checked = true;
            this.autoSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoSpace.ForeColor = System.Drawing.Color.White;
            this.autoSpace.Location = new System.Drawing.Point(44, 160);
            this.autoSpace.Name = "autoSpace";
            this.autoSpace.Size = new System.Drawing.Size(102, 20);
            this.autoSpace.TabIndex = 9;
            this.autoSpace.Text = "Автопробел";
            this.autoSpace.UseVisualStyleBackColor = false;
            this.autoSpace.Visible = false;
            this.autoSpace.MouseEnter += new System.EventHandler(this.autoSpace_MouseEnter);
            this.autoSpace.MouseLeave += new System.EventHandler(this.autoSpace_MouseLeave);
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.BackColor = System.Drawing.Color.Transparent;
            this.l3.Font = new System.Drawing.Font("Cambria", 14.25F);
            this.l3.ForeColor = System.Drawing.Color.White;
            this.l3.Location = new System.Drawing.Point(40, 100);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(96, 22);
            this.l3.TabIndex = 11;
            this.l3.Text = "Уровень 3";
            this.l3.Visible = false;
            this.l3.Click += new System.EventHandler(this.l3_Click);
            this.l3.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.l3.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // nudLive
            // 
            this.nudLive.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLive.Location = new System.Drawing.Point(44, 260);
            this.nudLive.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLive.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLive.Name = "nudLive";
            this.nudLive.Size = new System.Drawing.Size(120, 24);
            this.nudLive.TabIndex = 12;
            this.nudLive.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudLive.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Скорость(3-обычная)";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Жизней";
            this.label2.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.labelInfo.ForeColor = System.Drawing.Color.White;
            this.labelInfo.Location = new System.Drawing.Point(38, 397);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(109, 32);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "Об игре";
            this.labelInfo.Visible = false;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            this.labelInfo.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelInfo.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Громкость";
            this.label3.Visible = false;
            // 
            // nudVolume
            // 
            this.nudVolume.Location = new System.Drawing.Point(44, 310);
            this.nudVolume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVolume.Name = "nudVolume";
            this.nudVolume.Size = new System.Drawing.Size(120, 24);
            this.nudVolume.TabIndex = 16;
            this.nudVolume.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudVolume.Visible = false;
            this.nudVolume.ValueChanged += new System.EventHandler(this.nudVolume_ValueChanged);
            // 
            // labelMain
            // 
            this.labelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Font = new System.Drawing.Font("Cambria", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(312, 205);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(426, 79);
            this.labelMain.TabIndex = 18;
            this.labelMain.Text = "SpeedGrapher";
            this.labelMain.Click += new System.EventHandler(this.labelMain_Click);
            this.labelMain.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.labelMain.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // lExit
            // 
            this.lExit.AutoSize = true;
            this.lExit.BackColor = System.Drawing.Color.Transparent;
            this.lExit.Font = new System.Drawing.Font("Cambria", 20.25F);
            this.lExit.ForeColor = System.Drawing.Color.White;
            this.lExit.Location = new System.Drawing.Point(38, 446);
            this.lExit.Name = "lExit";
            this.lExit.Size = new System.Drawing.Size(91, 32);
            this.lExit.TabIndex = 19;
            this.lExit.Text = "Выход";
            this.lExit.Visible = false;
            this.lExit.Click += new System.EventHandler(this.lExit_Click);
            this.lExit.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.lExit.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::speedGrapher_Beta2.Properties.Resources._1627109228_12_kartinkin_com_p_anime_parni_na_chernom_fone_anime_krasivo_12;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lExit);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudVolume);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLive);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.autoSpace);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.CheckBox autoSpace;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.NumericUpDown nudLive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudVolume;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label lExit;
    }
}

