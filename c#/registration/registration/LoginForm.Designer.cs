namespace registration
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            RegisterLabel = new Label();
            loginButton = new Button();
            passwordField = new TextBox();
            passwordImage = new PictureBox();
            loginField = new TextBox();
            userImage = new PictureBox();
            panel2 = new Panel();
            closeButton = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 71, 80);
            panel1.Controls.Add(RegisterLabel);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(passwordImage);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(userImage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, -45);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 495);
            panel1.TabIndex = 0;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.Cursor = Cursors.Hand;
            RegisterLabel.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegisterLabel.ForeColor = SystemColors.ControlLightLight;
            RegisterLabel.Location = new Point(168, 425);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(126, 15);
            RegisterLabel.TabIndex = 5;
            RegisterLabel.Text = "Еще нет аккаунта?";
            RegisterLabel.Click += RegisterLabel_Click;
            RegisterLabel.MouseLeave += RegisterLabel_MouseLeave;
            RegisterLabel.MouseHover += RegisterLabel_MouseHover;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(215, 35, 35);
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(151, 28, 28);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginButton.ForeColor = Color.FromArgb(238, 238, 238);
            loginButton.Location = new Point(132, 382);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 40);
            loginButton.TabIndex = 4;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.Location = new Point(115, 285);
            passwordField.Name = "passwordField";
            passwordField.PasswordChar = '*';
            passwordField.Size = new Size(297, 45);
            passwordField.TabIndex = 3;
            passwordField.TextAlign = HorizontalAlignment.Center;
            passwordField.UseSystemPasswordChar = true;
            // 
            // passwordImage
            // 
            passwordImage.Image = Properties.Resources.lockicon;
            passwordImage.InitialImage = (Image)resources.GetObject("passwordImage.InitialImage");
            passwordImage.Location = new Point(31, 273);
            passwordImage.Name = "passwordImage";
            passwordImage.Size = new Size(68, 68);
            passwordImage.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordImage.TabIndex = 2;
            passwordImage.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(115, 175);
            loginField.Multiline = true;
            loginField.Name = "loginField";
            loginField.Size = new Size(297, 42);
            loginField.TabIndex = 1;
            loginField.TextAlign = HorizontalAlignment.Center;
            // 
            // userImage
            // 
            userImage.Image = Properties.Resources.usericon;
            userImage.InitialImage = (Image)resources.GetObject("userImage.InitialImage");
            userImage.Location = new Point(35, 165);
            userImage.Name = "userImage";
            userImage.Size = new Size(60, 60);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 56, 89);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 62);
            panel2.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(48, 56, 65);
            closeButton.BackgroundImage = Properties.Resources.closeicon;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = SystemColors.ButtonHighlight;
            closeButton.Location = new Point(420, 3);
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
            label1.Size = new Size(450, 62);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(450, 450);
            MinimumSize = new Size(450, 450);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox userImage;
        private TextBox loginField;
        private TextBox passwordField;
        private PictureBox passwordImage;
        private Button loginButton;
        private Button closeButton;
        private Label RegisterLabel;
    }
}