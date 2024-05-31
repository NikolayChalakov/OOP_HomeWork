namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbHero1 = new TextBox();
            tbHero2 = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(675, 63);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbHero1
            // 
            tbHero1.Location = new Point(23, 35);
            tbHero1.Multiline = true;
            tbHero1.Name = "tbHero1";
            tbHero1.Size = new Size(560, 437);
            tbHero1.TabIndex = 1;
            // 
            // tbHero2
            // 
            tbHero2.Location = new Point(879, 44);
            tbHero2.Multiline = true;
            tbHero2.Name = "tbHero2";
            tbHero2.Size = new Size(560, 437);
            tbHero2.TabIndex = 2;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(620, 347);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(206, 134);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(631, 121);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(206, 89);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            lbWinner.Click += lbWinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(879, 18);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 5;
            label1.Text = "Assassin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "Knight:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sword", "Dagger", "LightingSword", "EarthShield", "PokerCard" });
            comboBox1.Location = new Point(589, 251);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(106, 28);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(589, 285);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 8;
            button1.Text = "Info\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Sword", "Dagger", "LightingSword", "EarthShield", "PokerCard" });
            comboBox2.Location = new Point(767, 251);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 28);
            comboBox2.TabIndex = 9;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(767, 285);
            button2.Name = "button2";
            button2.Size = new Size(106, 29);
            button2.TabIndex = 10;
            button2.Text = "Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(605, 228);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Weapons";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 228);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Weapons";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Knight", "Assassin", "Barbarian", "Archer", "Summoner" });
            comboBox3.Location = new Point(589, 164);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(106, 28);
            comboBox3.TabIndex = 13;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Knight", "Assassin", "Barbarian", "Archer", "Summoner" });
            comboBox4.Location = new Point(767, 164);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(106, 28);
            comboBox4.TabIndex = 14;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 504);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbHero2);
            Controls.Add(tbHero1);
            Controls.Add(btnNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbHero1;
        private TextBox tbHero2;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
    }
}