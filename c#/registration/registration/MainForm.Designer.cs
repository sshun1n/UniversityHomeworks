namespace registration
{
    partial class MainForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            closeButton = new Button();
            label1 = new Label();
            welcomeLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 71, 80);
            panel1.Controls.Add(welcomeLabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 312);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 56, 89);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 76);
            panel2.TabIndex = 3;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(48, 56, 65);
            closeButton.BackgroundImage = Properties.Resources.closeicon;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = SystemColors.ButtonHighlight;
            closeButton.Location = new Point(430, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(27, 27);
            closeButton.TabIndex = 1;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(48, 56, 65);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Consolas", 28F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(460, 76);
            label1.TabIndex = 0;
            label1.Text = "Главный экран";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown_1;
            label1.MouseMove += label1_MouseMove_1;
            // 
            // welcomeLabel
            // 
            welcomeLabel.Dock = DockStyle.Bottom;
            welcomeLabel.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeLabel.ForeColor = Color.FromArgb(238, 238, 238);
            welcomeLabel.Location = new Point(0, 0);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(460, 312);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Добро пожаловать!";
            welcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 388);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button closeButton;
        private Label label1;
        private Label welcomeLabel;
    }
}