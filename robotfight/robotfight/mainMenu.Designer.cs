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
            pokemonDrop = new ComboBox();
            l1 = new Label();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(326, 146);
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
            label1.Location = new Point(114, 37);
            label1.Name = "label1";
            label1.Size = new Size(601, 106);
            label1.TabIndex = 1;
            label1.Text = "Pokemon Battle";
            label1.Click += label1_Click;
            // 
            // pokemonDrop
            // 
            pokemonDrop.DropDownHeight = 200;
            pokemonDrop.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pokemonDrop.FormattingEnabled = true;
            pokemonDrop.IntegralHeight = false;
            pokemonDrop.Items.AddRange(new object[] { "Pikachu", "Charmander", "Bulbasaur", "Squirtle", "Eevee", "Onix", "Riolu", "Dratini" });
            pokemonDrop.Location = new Point(263, 304);
            pokemonDrop.Name = "pokemonDrop";
            pokemonDrop.Size = new Size(281, 62);
            pokemonDrop.TabIndex = 6;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l1.Location = new Point(229, 241);
            l1.Name = "l1";
            l1.Size = new Size(351, 41);
            l1.TabIndex = 5;
            l1.Text = "Choose your Pokemon!";
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pokemonDrop);
            Controls.Add(l1);
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
        private ComboBox pokemonDrop;
        private Label l1;
    }
}