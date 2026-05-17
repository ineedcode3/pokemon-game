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
            b3 = new Button();
            l1 = new Label();
            SuspendLayout();
            // 
            // startBtn
            // 
            startBtn.Location = new Point(313, 156);
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
            label1.Location = new Point(113, 30);
            label1.Name = "label1";
            label1.Size = new Size(601, 106);
            label1.TabIndex = 1;
            label1.Text = "Pokemon Battle";
            // 
            // b1
            // 
            b1.Location = new Point(69, 289);
            b1.Name = "b1";
            b1.Size = new Size(162, 70);
            b1.TabIndex = 2;
            b1.Text = "Pikachu";
            b1.UseVisualStyleBackColor = true;
            b1.Visible = false;
            b1.Click += b1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(313, 289);
            b2.Name = "b2";
            b2.Size = new Size(162, 70);
            b2.TabIndex = 3;
            b2.Text = "Charmander";
            b2.UseVisualStyleBackColor = true;
            b2.Visible = false;
            b2.Click += b2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(552, 289);
            b3.Name = "b3";
            b3.Size = new Size(162, 70);
            b3.TabIndex = 4;
            b3.Text = "Bulbasaur";
            b3.UseVisualStyleBackColor = true;
            b3.Visible = false;
            b3.Click += b3_Click;
            // 
            // l1
            // 
            l1.AutoSize = true;
            l1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            l1.Location = new Point(219, 174);
            l1.Name = "l1";
            l1.Size = new Size(351, 41);
            l1.TabIndex = 5;
            l1.Text = "Choose your Pokemon!";
            l1.Visible = false;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(l1);
            Controls.Add(b3);
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
        private Button b3;
        private Label l1;
    }
}