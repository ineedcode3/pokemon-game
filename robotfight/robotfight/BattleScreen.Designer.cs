namespace robotfight
{
    partial class BattleScreen
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
            pictureBox1 = new PictureBox();
            Attack1 = new Button();
            Attack2 = new Button();
            Attack3 = new Button();
            Attack4 = new Button();
            pictureBox2 = new PictureBox();
            EnemyImage = new PictureBox();
            pictureBox3 = new PictureBox();
            PlayerNameTag = new Label();
            HealthPlayer = new Label();
            EnemyNameTag = new Label();
            EnemyHealth = new Label();
            pictureBox4 = new PictureBox();
            InfoText = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.pikcachu;
            pictureBox1.Location = new Point(47, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Attack1
            // 
            Attack1.Location = new Point(399, 334);
            Attack1.Name = "Attack1";
            Attack1.Size = new Size(179, 44);
            Attack1.TabIndex = 2;
            Attack1.Text = "Quick Attack";
            Attack1.UseVisualStyleBackColor = true;
            Attack1.Click += button1_Click;
            // 
            // Attack2
            // 
            Attack2.Location = new Point(581, 334);
            Attack2.Name = "Attack2";
            Attack2.Size = new Size(179, 44);
            Attack2.TabIndex = 3;
            Attack2.Text = "Volt Tackle";
            Attack2.UseVisualStyleBackColor = true;
            Attack2.Click += button2_Click;
            // 
            // Attack3
            // 
            Attack3.Location = new Point(399, 384);
            Attack3.Name = "Attack3";
            Attack3.Size = new Size(179, 44);
            Attack3.TabIndex = 4;
            Attack3.Text = "Spark";
            Attack3.UseVisualStyleBackColor = true;
            Attack3.Click += button3_Click;
            // 
            // Attack4
            // 
            Attack4.Location = new Point(581, 384);
            Attack4.Name = "Attack4";
            Attack4.Size = new Size(179, 44);
            Attack4.TabIndex = 5;
            Attack4.Text = "Thunder Shock";
            Attack4.UseVisualStyleBackColor = true;
            Attack4.Click += button4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightGray;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(12, 322);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 116);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // EnemyImage
            // 
            EnemyImage.BackgroundImageLayout = ImageLayout.None;
            EnemyImage.Image = Properties.Resources.meowth_removebg_preview;
            EnemyImage.Location = new Point(508, 60);
            EnemyImage.Name = "EnemyImage";
            EnemyImage.Size = new Size(154, 151);
            EnemyImage.SizeMode = PictureBoxSizeMode.StretchImage;
            EnemyImage.TabIndex = 7;
            EnemyImage.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightGray;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(475, 230);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(385, 76);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // PlayerNameTag
            // 
            PlayerNameTag.AutoSize = true;
            PlayerNameTag.BackColor = Color.LightGray;
            PlayerNameTag.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayerNameTag.Location = new Point(494, 253);
            PlayerNameTag.Name = "PlayerNameTag";
            PlayerNameTag.Size = new Size(111, 33);
            PlayerNameTag.TabIndex = 11;
            PlayerNameTag.Text = "Pikachu";
            // 
            // HealthPlayer
            // 
            HealthPlayer.AutoSize = true;
            HealthPlayer.BackColor = Color.LightGray;
            HealthPlayer.BorderStyle = BorderStyle.FixedSingle;
            HealthPlayer.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HealthPlayer.Location = new Point(694, 251);
            HealthPlayer.Name = "HealthPlayer";
            HealthPlayer.Size = new Size(94, 35);
            HealthPlayer.TabIndex = 10;
            HealthPlayer.Text = "100hp";
            // 
            // EnemyNameTag
            // 
            EnemyNameTag.AutoSize = true;
            EnemyNameTag.BackColor = Color.LightGray;
            EnemyNameTag.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnemyNameTag.Location = new Point(56, 82);
            EnemyNameTag.Name = "EnemyNameTag";
            EnemyNameTag.Size = new Size(116, 33);
            EnemyNameTag.TabIndex = 14;
            EnemyNameTag.Text = "Meowth";
            // 
            // EnemyHealth
            // 
            EnemyHealth.AutoSize = true;
            EnemyHealth.BackColor = Color.LightGray;
            EnemyHealth.BorderStyle = BorderStyle.FixedSingle;
            EnemyHealth.Font = new Font("Gadugi", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EnemyHealth.Location = new Point(244, 82);
            EnemyHealth.Name = "EnemyHealth";
            EnemyHealth.Size = new Size(94, 35);
            EnemyHealth.TabIndex = 13;
            EnemyHealth.Text = "100hp";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.LightGray;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(-30, 60);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(385, 76);
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // InfoText
            // 
            InfoText.BorderStyle = BorderStyle.FixedSingle;
            InfoText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InfoText.Location = new Point(22, 334);
            InfoText.Name = "InfoText";
            InfoText.Size = new Size(362, 94);
            InfoText.TabIndex = 15;
            InfoText.Text = "A meowth has appeared to battle you!";
            // 
            // BattleScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InfoText);
            Controls.Add(EnemyNameTag);
            Controls.Add(EnemyHealth);
            Controls.Add(pictureBox4);
            Controls.Add(PlayerNameTag);
            Controls.Add(HealthPlayer);
            Controls.Add(pictureBox3);
            Controls.Add(EnemyImage);
            Controls.Add(Attack4);
            Controls.Add(Attack3);
            Controls.Add(Attack2);
            Controls.Add(Attack1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MaximumSize = new Size(818, 497);
            MinimizeBox = false;
            MinimumSize = new Size(818, 497);
            Name = "BattleScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PokemonBattles";
            FormClosing += BattleScreen_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemyImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Attack1;
        private Button Attack2;
        private Button Attack3;
        private Button Attack4;
        private PictureBox pictureBox2;
        private PictureBox EnemyImage;
        private PictureBox pictureBox3;
        private Label PlayerNameTag;
        private Label HealthPlayer;
        private Label EnemyNameTag;
        private Label EnemyHealth;
        private PictureBox pictureBox4;
        private Label InfoText;
    }
}
