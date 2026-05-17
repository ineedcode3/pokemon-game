namespace robotfight
{
    partial class mainMenu
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
            startBtn = new Button();
            label1 = new Label();
            b1 = new Button();
            b2 = new Button();
            l1 = new Label();
            b3 = new Button();
            pokemonDrop = new ComboBox();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(113, 168);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(162, 70);
            startBtn.TabIndex = 0;
            startBtn.Text = "Start";
            startBtn.UseVisualStyleBackColor = true;
            startBtn.Click += startBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, -1);
            label1.Name = "label1";
            label1.Size = new Size(601, 106);
            label1.TabIndex = 1;
            label1.Text = "Pokemon Battle";
            label1.Click += label1_Click;
            // 
            // b1
            // 
            b1.FlatStyle = FlatStyle.Flat;
            b1.ImageAlign = ContentAlignment.TopLeft;
            b1.Location = new Point(138, 249);
            b1.Name = "b1";
            b1.Size = new Size(310, 40);
            b1.TabIndex = 2;
            b1.Text = "Pikachu";
            b1.TextAlign = ContentAlignment.MiddleLeft;
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.FlatStyle = FlatStyle.Flat;
            b2.ImageAlign = ContentAlignment.TopLeft;
            b2.Location = new Point(138, 341);
            b2.Name = "b2";
            b2.Size = new Size(310, 40);
            b2.TabIndex = 3;
            b2.Text = "Charmander";
            b2.TextAlign = ContentAlignment.MiddleLeft;
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l1.Location = new Point(363, 152);
            l1.Name = "l1";
            l1.Size = new Size(351, 41);
            l1.TabIndex = 5;
            l1.Text = "Choose your Pokemon!";
            l1.Visible = false;
            // 
            // b3
            // 
            b3.FlatStyle = FlatStyle.Flat;
            b3.ImageAlign = ContentAlignment.TopLeft;
            b3.Location = new Point(138, 295);
            b3.Name = "b3";
            b3.Size = new Size(310, 40);
            b3.TabIndex = 4;
            b3.Text = "Bulbasaur";
            b3.TextAlign = ContentAlignment.MiddleLeft;
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // pokemonDrop
            // 
            pokemonDrop.FormattingEnabled = true;
            pokemonDrop.Items.AddRange(new object[] { "Pikachu", "Charmander", "Bulbasaur" });
            pokemonDrop.Location = new Point(475, 210);
            pokemonDrop.Name = "pokemonDrop";
            pokemonDrop.Size = new Size(223, 28);
            pokemonDrop.TabIndex = 6;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pokemonDrop);
            Controls.Add(b3);
            Controls.Add(l1);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(label1);
            Controls.Add(startBtn);
            MaximumSize = new Size(818, 497);
            MinimumSize = new Size(818, 497);
            Name = "mainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startBtn;
        private Label label1;
        private Button b1;
        private Button b2;
        private Label l1;
        private Button b3;
        private ComboBox pokemonDrop;
    }
}