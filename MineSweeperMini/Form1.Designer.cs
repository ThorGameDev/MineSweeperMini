namespace MineSweeperMini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Board = new System.Windows.Forms.FlowLayoutPanel();
            this.t1_1 = new System.Windows.Forms.PictureBox();
            this.numberTiles = new System.Windows.Forms.ImageList(this.components);
            this.t1_2 = new System.Windows.Forms.PictureBox();
            this.t1_3 = new System.Windows.Forms.PictureBox();
            this.t1_4 = new System.Windows.Forms.PictureBox();
            this.t1_5 = new System.Windows.Forms.PictureBox();
            this.t2_1 = new System.Windows.Forms.PictureBox();
            this.t2_2 = new System.Windows.Forms.PictureBox();
            this.t2_3 = new System.Windows.Forms.PictureBox();
            this.t2_4 = new System.Windows.Forms.PictureBox();
            this.t2_5 = new System.Windows.Forms.PictureBox();
            this.t3_1 = new System.Windows.Forms.PictureBox();
            this.t3_2 = new System.Windows.Forms.PictureBox();
            this.t3_3 = new System.Windows.Forms.PictureBox();
            this.t3_4 = new System.Windows.Forms.PictureBox();
            this.t3_5 = new System.Windows.Forms.PictureBox();
            this.t4_1 = new System.Windows.Forms.PictureBox();
            this.t4_2 = new System.Windows.Forms.PictureBox();
            this.t4_3 = new System.Windows.Forms.PictureBox();
            this.t4_4 = new System.Windows.Forms.PictureBox();
            this.t4_5 = new System.Windows.Forms.PictureBox();
            this.t5_1 = new System.Windows.Forms.PictureBox();
            this.t5_2 = new System.Windows.Forms.PictureBox();
            this.t5_3 = new System.Windows.Forms.PictureBox();
            this.t5_4 = new System.Windows.Forms.PictureBox();
            this.t5_5 = new System.Windows.Forms.PictureBox();
            this.otherTiles = new System.Windows.Forms.ImageList(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timeIndicator = new System.Windows.Forms.Label();
            this.totalBombsLabel = new System.Windows.Forms.Label();
            this.bestTime = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.t1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_5)).BeginInit();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.Controls.Add(this.t1_1);
            this.Board.Controls.Add(this.t1_2);
            this.Board.Controls.Add(this.t1_3);
            this.Board.Controls.Add(this.t1_4);
            this.Board.Controls.Add(this.t1_5);
            this.Board.Controls.Add(this.t2_1);
            this.Board.Controls.Add(this.t2_2);
            this.Board.Controls.Add(this.t2_3);
            this.Board.Controls.Add(this.t2_4);
            this.Board.Controls.Add(this.t2_5);
            this.Board.Controls.Add(this.t3_1);
            this.Board.Controls.Add(this.t3_2);
            this.Board.Controls.Add(this.t3_3);
            this.Board.Controls.Add(this.t3_4);
            this.Board.Controls.Add(this.t3_5);
            this.Board.Controls.Add(this.t4_1);
            this.Board.Controls.Add(this.t4_2);
            this.Board.Controls.Add(this.t4_3);
            this.Board.Controls.Add(this.t4_4);
            this.Board.Controls.Add(this.t4_5);
            this.Board.Controls.Add(this.t5_1);
            this.Board.Controls.Add(this.t5_2);
            this.Board.Controls.Add(this.t5_3);
            this.Board.Controls.Add(this.t5_4);
            this.Board.Controls.Add(this.t5_5);
            this.Board.Location = new System.Drawing.Point(12, 12);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(434, 434);
            this.Board.TabIndex = 0;
            // 
            // t1_1
            // 
            this.t1_1.Image = ((System.Drawing.Image)(resources.GetObject("t1_1.Image")));
            this.t1_1.Location = new System.Drawing.Point(3, 3);
            this.t1_1.Name = "t1_1";
            this.t1_1.Size = new System.Drawing.Size(80, 80);
            this.t1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_1.TabIndex = 0;
            this.t1_1.TabStop = false;
            this.t1_1.Click += new System.EventHandler(this.play_spot);
            // 
            // numberTiles
            // 
            this.numberTiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("numberTiles.ImageStream")));
            this.numberTiles.TransparentColor = System.Drawing.Color.Transparent;
            this.numberTiles.Images.SetKeyName(0, "0.png");
            this.numberTiles.Images.SetKeyName(1, "1.png");
            this.numberTiles.Images.SetKeyName(2, "2.png");
            this.numberTiles.Images.SetKeyName(3, "3.png");
            this.numberTiles.Images.SetKeyName(4, "4.png");
            this.numberTiles.Images.SetKeyName(5, "5.png");
            this.numberTiles.Images.SetKeyName(6, "6.png");
            this.numberTiles.Images.SetKeyName(7, "7.png");
            this.numberTiles.Images.SetKeyName(8, "8.png");
            // 
            // t1_2
            // 
            this.t1_2.Image = ((System.Drawing.Image)(resources.GetObject("t1_2.Image")));
            this.t1_2.Location = new System.Drawing.Point(89, 3);
            this.t1_2.Name = "t1_2";
            this.t1_2.Size = new System.Drawing.Size(80, 80);
            this.t1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_2.TabIndex = 1;
            this.t1_2.TabStop = false;
            this.t1_2.Click += new System.EventHandler(this.play_spot);
            // 
            // t1_3
            // 
            this.t1_3.Image = ((System.Drawing.Image)(resources.GetObject("t1_3.Image")));
            this.t1_3.Location = new System.Drawing.Point(175, 3);
            this.t1_3.Name = "t1_3";
            this.t1_3.Size = new System.Drawing.Size(80, 80);
            this.t1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_3.TabIndex = 2;
            this.t1_3.TabStop = false;
            this.t1_3.Click += new System.EventHandler(this.play_spot);
            // 
            // t1_4
            // 
            this.t1_4.Image = ((System.Drawing.Image)(resources.GetObject("t1_4.Image")));
            this.t1_4.Location = new System.Drawing.Point(261, 3);
            this.t1_4.Name = "t1_4";
            this.t1_4.Size = new System.Drawing.Size(80, 80);
            this.t1_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_4.TabIndex = 3;
            this.t1_4.TabStop = false;
            this.t1_4.Click += new System.EventHandler(this.play_spot);
            // 
            // t1_5
            // 
            this.t1_5.Image = ((System.Drawing.Image)(resources.GetObject("t1_5.Image")));
            this.t1_5.Location = new System.Drawing.Point(347, 3);
            this.t1_5.Name = "t1_5";
            this.t1_5.Size = new System.Drawing.Size(80, 80);
            this.t1_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t1_5.TabIndex = 4;
            this.t1_5.TabStop = false;
            this.t1_5.Click += new System.EventHandler(this.play_spot);
            // 
            // t2_1
            // 
            this.t2_1.Image = ((System.Drawing.Image)(resources.GetObject("t2_1.Image")));
            this.t2_1.Location = new System.Drawing.Point(3, 89);
            this.t2_1.Name = "t2_1";
            this.t2_1.Size = new System.Drawing.Size(80, 80);
            this.t2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_1.TabIndex = 5;
            this.t2_1.TabStop = false;
            this.t2_1.Click += new System.EventHandler(this.play_spot);
            // 
            // t2_2
            // 
            this.t2_2.Image = ((System.Drawing.Image)(resources.GetObject("t2_2.Image")));
            this.t2_2.Location = new System.Drawing.Point(89, 89);
            this.t2_2.Name = "t2_2";
            this.t2_2.Size = new System.Drawing.Size(80, 80);
            this.t2_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_2.TabIndex = 6;
            this.t2_2.TabStop = false;
            this.t2_2.Click += new System.EventHandler(this.play_spot);
            // 
            // t2_3
            // 
            this.t2_3.Image = ((System.Drawing.Image)(resources.GetObject("t2_3.Image")));
            this.t2_3.Location = new System.Drawing.Point(175, 89);
            this.t2_3.Name = "t2_3";
            this.t2_3.Size = new System.Drawing.Size(80, 80);
            this.t2_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_3.TabIndex = 7;
            this.t2_3.TabStop = false;
            this.t2_3.Click += new System.EventHandler(this.play_spot);
            // 
            // t2_4
            // 
            this.t2_4.Image = ((System.Drawing.Image)(resources.GetObject("t2_4.Image")));
            this.t2_4.Location = new System.Drawing.Point(261, 89);
            this.t2_4.Name = "t2_4";
            this.t2_4.Size = new System.Drawing.Size(80, 80);
            this.t2_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_4.TabIndex = 8;
            this.t2_4.TabStop = false;
            this.t2_4.Click += new System.EventHandler(this.play_spot);
            // 
            // t2_5
            // 
            this.t2_5.Image = ((System.Drawing.Image)(resources.GetObject("t2_5.Image")));
            this.t2_5.Location = new System.Drawing.Point(347, 89);
            this.t2_5.Name = "t2_5";
            this.t2_5.Size = new System.Drawing.Size(80, 80);
            this.t2_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t2_5.TabIndex = 9;
            this.t2_5.TabStop = false;
            this.t2_5.Click += new System.EventHandler(this.play_spot);
            // 
            // t3_1
            // 
            this.t3_1.Image = ((System.Drawing.Image)(resources.GetObject("t3_1.Image")));
            this.t3_1.Location = new System.Drawing.Point(3, 175);
            this.t3_1.Name = "t3_1";
            this.t3_1.Size = new System.Drawing.Size(80, 80);
            this.t3_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3_1.TabIndex = 10;
            this.t3_1.TabStop = false;
            this.t3_1.Click += new System.EventHandler(this.play_spot);
            // 
            // t3_2
            // 
            this.t3_2.Image = ((System.Drawing.Image)(resources.GetObject("t3_2.Image")));
            this.t3_2.Location = new System.Drawing.Point(89, 175);
            this.t3_2.Name = "t3_2";
            this.t3_2.Size = new System.Drawing.Size(80, 80);
            this.t3_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3_2.TabIndex = 11;
            this.t3_2.TabStop = false;
            this.t3_2.Click += new System.EventHandler(this.play_spot);
            // 
            // t3_3
            // 
            this.t3_3.Image = ((System.Drawing.Image)(resources.GetObject("t3_3.Image")));
            this.t3_3.Location = new System.Drawing.Point(175, 175);
            this.t3_3.Name = "t3_3";
            this.t3_3.Size = new System.Drawing.Size(80, 80);
            this.t3_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3_3.TabIndex = 12;
            this.t3_3.TabStop = false;
            this.t3_3.Click += new System.EventHandler(this.play_spot);
            // 
            // t3_4
            // 
            this.t3_4.Image = ((System.Drawing.Image)(resources.GetObject("t3_4.Image")));
            this.t3_4.Location = new System.Drawing.Point(261, 175);
            this.t3_4.Name = "t3_4";
            this.t3_4.Size = new System.Drawing.Size(80, 80);
            this.t3_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3_4.TabIndex = 13;
            this.t3_4.TabStop = false;
            this.t3_4.Click += new System.EventHandler(this.play_spot);
            // 
            // t3_5
            // 
            this.t3_5.Image = ((System.Drawing.Image)(resources.GetObject("t3_5.Image")));
            this.t3_5.Location = new System.Drawing.Point(347, 175);
            this.t3_5.Name = "t3_5";
            this.t3_5.Size = new System.Drawing.Size(80, 80);
            this.t3_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t3_5.TabIndex = 14;
            this.t3_5.TabStop = false;
            this.t3_5.Click += new System.EventHandler(this.play_spot);
            // 
            // t4_1
            // 
            this.t4_1.Image = ((System.Drawing.Image)(resources.GetObject("t4_1.Image")));
            this.t4_1.Location = new System.Drawing.Point(3, 261);
            this.t4_1.Name = "t4_1";
            this.t4_1.Size = new System.Drawing.Size(80, 80);
            this.t4_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4_1.TabIndex = 15;
            this.t4_1.TabStop = false;
            this.t4_1.Click += new System.EventHandler(this.play_spot);
            // 
            // t4_2
            // 
            this.t4_2.Image = ((System.Drawing.Image)(resources.GetObject("t4_2.Image")));
            this.t4_2.Location = new System.Drawing.Point(89, 261);
            this.t4_2.Name = "t4_2";
            this.t4_2.Size = new System.Drawing.Size(80, 80);
            this.t4_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4_2.TabIndex = 16;
            this.t4_2.TabStop = false;
            this.t4_2.Click += new System.EventHandler(this.play_spot);
            // 
            // t4_3
            // 
            this.t4_3.Image = ((System.Drawing.Image)(resources.GetObject("t4_3.Image")));
            this.t4_3.Location = new System.Drawing.Point(175, 261);
            this.t4_3.Name = "t4_3";
            this.t4_3.Size = new System.Drawing.Size(80, 80);
            this.t4_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4_3.TabIndex = 17;
            this.t4_3.TabStop = false;
            this.t4_3.Click += new System.EventHandler(this.play_spot);
            // 
            // t4_4
            // 
            this.t4_4.Image = ((System.Drawing.Image)(resources.GetObject("t4_4.Image")));
            this.t4_4.Location = new System.Drawing.Point(261, 261);
            this.t4_4.Name = "t4_4";
            this.t4_4.Size = new System.Drawing.Size(80, 80);
            this.t4_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4_4.TabIndex = 18;
            this.t4_4.TabStop = false;
            this.t4_4.Click += new System.EventHandler(this.play_spot);
            // 
            // t4_5
            // 
            this.t4_5.Image = ((System.Drawing.Image)(resources.GetObject("t4_5.Image")));
            this.t4_5.Location = new System.Drawing.Point(347, 261);
            this.t4_5.Name = "t4_5";
            this.t4_5.Size = new System.Drawing.Size(80, 80);
            this.t4_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t4_5.TabIndex = 19;
            this.t4_5.TabStop = false;
            this.t4_5.Click += new System.EventHandler(this.play_spot);
            // 
            // t5_1
            // 
            this.t5_1.Image = ((System.Drawing.Image)(resources.GetObject("t5_1.Image")));
            this.t5_1.Location = new System.Drawing.Point(3, 347);
            this.t5_1.Name = "t5_1";
            this.t5_1.Size = new System.Drawing.Size(80, 80);
            this.t5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5_1.TabIndex = 20;
            this.t5_1.TabStop = false;
            this.t5_1.Click += new System.EventHandler(this.play_spot);
            // 
            // t5_2
            // 
            this.t5_2.Image = ((System.Drawing.Image)(resources.GetObject("t5_2.Image")));
            this.t5_2.Location = new System.Drawing.Point(89, 347);
            this.t5_2.Name = "t5_2";
            this.t5_2.Size = new System.Drawing.Size(80, 80);
            this.t5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5_2.TabIndex = 21;
            this.t5_2.TabStop = false;
            this.t5_2.Click += new System.EventHandler(this.play_spot);
            // 
            // t5_3
            // 
            this.t5_3.Image = ((System.Drawing.Image)(resources.GetObject("t5_3.Image")));
            this.t5_3.Location = new System.Drawing.Point(175, 347);
            this.t5_3.Name = "t5_3";
            this.t5_3.Size = new System.Drawing.Size(80, 80);
            this.t5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5_3.TabIndex = 22;
            this.t5_3.TabStop = false;
            this.t5_3.Click += new System.EventHandler(this.play_spot);
            // 
            // t5_4
            // 
            this.t5_4.Image = ((System.Drawing.Image)(resources.GetObject("t5_4.Image")));
            this.t5_4.Location = new System.Drawing.Point(261, 347);
            this.t5_4.Name = "t5_4";
            this.t5_4.Size = new System.Drawing.Size(80, 80);
            this.t5_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5_4.TabIndex = 23;
            this.t5_4.TabStop = false;
            this.t5_4.Click += new System.EventHandler(this.play_spot);
            // 
            // t5_5
            // 
            this.t5_5.Image = ((System.Drawing.Image)(resources.GetObject("t5_5.Image")));
            this.t5_5.Location = new System.Drawing.Point(347, 347);
            this.t5_5.Name = "t5_5";
            this.t5_5.Size = new System.Drawing.Size(80, 80);
            this.t5_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.t5_5.TabIndex = 24;
            this.t5_5.TabStop = false;
            this.t5_5.Click += new System.EventHandler(this.play_spot);
            // 
            // otherTiles
            // 
            this.otherTiles.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("otherTiles.ImageStream")));
            this.otherTiles.TransparentColor = System.Drawing.Color.Transparent;
            this.otherTiles.Images.SetKeyName(0, "Untouched.png");
            this.otherTiles.Images.SetKeyName(1, "Flag.png");
            this.otherTiles.Images.SetKeyName(2, "Mine.png");
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.timer_increment);
            // 
            // timeIndicator
            // 
            this.timeIndicator.AutoSize = true;
            this.timeIndicator.Location = new System.Drawing.Point(12, 449);
            this.timeIndicator.Name = "timeIndicator";
            this.timeIndicator.Size = new System.Drawing.Size(42, 13);
            this.timeIndicator.TabIndex = 1;
            this.timeIndicator.Text = "Time: 0";
            // 
            // totalBombsLabel
            // 
            this.totalBombsLabel.AutoSize = true;
            this.totalBombsLabel.Location = new System.Drawing.Point(284, 449);
            this.totalBombsLabel.Name = "totalBombsLabel";
            this.totalBombsLabel.Size = new System.Drawing.Size(90, 13);
            this.totalBombsLabel.TabIndex = 2;
            this.totalBombsLabel.Text = "Total Bombs: ???";
            // 
            // bestTime
            // 
            this.bestTime.AutoSize = true;
            this.bestTime.Location = new System.Drawing.Point(129, 449);
            this.bestTime.Name = "bestTime";
            this.bestTime.Size = new System.Drawing.Size(80, 13);
            this.bestTime.TabIndex = 3;
            this.bestTime.Text = "Best Time: N/A";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(15, 466);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(424, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 501);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bestTime);
            this.Controls.Add(this.totalBombsLabel);
            this.Controls.Add(this.timeIndicator);
            this.Controls.Add(this.Board);
            this.Name = "Form1";
            this.Text = "Mine Sweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.t1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t1_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t2_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t3_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t4_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t5_5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Board;
        private System.Windows.Forms.PictureBox t1_1;
        private System.Windows.Forms.ImageList numberTiles;
        private System.Windows.Forms.PictureBox t1_2;
        private System.Windows.Forms.PictureBox t1_3;
        private System.Windows.Forms.PictureBox t1_4;
        private System.Windows.Forms.PictureBox t1_5;
        private System.Windows.Forms.PictureBox t2_1;
        private System.Windows.Forms.PictureBox t2_2;
        private System.Windows.Forms.PictureBox t2_3;
        private System.Windows.Forms.PictureBox t2_4;
        private System.Windows.Forms.PictureBox t2_5;
        private System.Windows.Forms.PictureBox t3_1;
        private System.Windows.Forms.PictureBox t3_2;
        private System.Windows.Forms.PictureBox t3_3;
        private System.Windows.Forms.PictureBox t3_4;
        private System.Windows.Forms.PictureBox t3_5;
        private System.Windows.Forms.PictureBox t4_1;
        private System.Windows.Forms.PictureBox t4_2;
        private System.Windows.Forms.PictureBox t4_3;
        private System.Windows.Forms.PictureBox t4_4;
        private System.Windows.Forms.PictureBox t4_5;
        private System.Windows.Forms.PictureBox t5_1;
        private System.Windows.Forms.PictureBox t5_2;
        private System.Windows.Forms.PictureBox t5_3;
        private System.Windows.Forms.PictureBox t5_4;
        private System.Windows.Forms.PictureBox t5_5;
        private System.Windows.Forms.ImageList otherTiles;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label timeIndicator;
        private System.Windows.Forms.Label totalBombsLabel;
        private System.Windows.Forms.Label bestTime;
        private System.Windows.Forms.Button exit;
    }
}

