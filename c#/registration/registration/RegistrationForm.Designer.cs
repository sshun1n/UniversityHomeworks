namespace registration
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel1 = new Panel();
            LoginLabel = new Label();
            surnameLabel = new Label();
            nameLabel = new Label();
            pictureBox1 = new PictureBox();
            lastnameField = new TextBox();
            firstnameField = new TextBox();
            RegisterButton = new Button();
            passwordField = new TextBox();
            passwordImage = new PictureBox();
            loginField = new TextBox();
            userImage = new PictureBox();
            closeButton = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userImage).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 71, 80);
            panel1.Controls.Add(LoginLabel);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lastnameField);
            panel1.Controls.Add(firstnameField);
            panel1.Controls.Add(RegisterButton);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(passwordImage);
            panel1.Controls.Add(loginField);
            panel1.Controls.Add(userImage);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 382);
            panel1.TabIndex = 2;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Cursor = Cursors.Hand;
            LoginLabel.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLabel.ForeColor = SystemColors.ControlLightLight;
            LoginLabel.Location = new Point(358, 303);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(126, 15);
            LoginLabel.TabIndex = 10;
            LoginLabel.Text = "Уже есть аккаунт?";
            LoginLabel.Click += LoginLabel_Click;
            LoginLabel.MouseLeave += LoginLabel_MouseLeave;
            LoginLabel.MouseHover += LoginLabel_MouseHover;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            surnameLabel.ForeColor = Color.FromArgb(238, 238, 238);
            surnameLabel.Location = new Point(467, 44);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(90, 22);
            surnameLabel.TabIndex = 9;
            surnameLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameLabel.ForeColor = Color.FromArgb(238, 238, 238);
            nameLabel.Location = new Point(145, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 22);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Имя:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nameicon;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(46, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lastnameField
            // 
            lastnameField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lastnameField.Location = new Point(467, 72);
            lastnameField.Multiline = true;
            lastnameField.Name = "lastnameField";
            lastnameField.Size = new Size(297, 42);
            lastnameField.TabIndex = 6;
            lastnameField.TextAlign = HorizontalAlignment.Center;
            lastnameField.Enter += lastnameField_Enter;
            lastnameField.Leave += lastnameField_Leave;
            // 
            // firstnameField
            // 
            firstnameField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstnameField.Location = new Point(142, 72);
            firstnameField.Multiline = true;
            firstnameField.Name = "firstnameField";
            firstnameField.Size = new Size(297, 42);
            firstnameField.TabIndex = 5;
            firstnameField.TextAlign = HorizontalAlignment.Center;
            firstnameField.Enter += firstnameField_Enter;
            firstnameField.Leave += firstnameField_Leave;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.FromArgb(215, 35, 35);
            RegisterButton.FlatAppearance.BorderColor = Color.FromArgb(238, 238, 238);
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(151, 28, 28);
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RegisterButton.ForeColor = Color.FromArgb(238, 238, 238);
            RegisterButton.Location = new Point(268, 257);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(307, 43);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Зарегистрироваться";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // passwordField
            // 
            passwordField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            passwordField.Location = new Point(524, 179);
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
            passwordImage.Location = new Point(440, 167);
            passwordImage.Name = "passwordImage";
            passwordImage.Size = new Size(68, 68);
            passwordImage.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordImage.TabIndex = 2;
            passwordImage.TabStop = false;
            // 
            // loginField
            // 
            loginField.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            loginField.Location = new Point(99, 182);
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
            userImage.Location = new Point(19, 172);
            userImage.Name = "userImage";
            userImage.Size = new Size(60, 60);
            userImage.SizeMode = PictureBoxSizeMode.StretchImage;
            userImage.TabIndex = 0;
            userImage.TabStop = false;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.FromArgb(48, 56, 65);
            closeButton.BackgroundImage = Properties.Resources.closeicon;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.ForeColor = SystemColors.ButtonHighlight;
            closeButton.Location = new Point(817, 3);
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
            label1.Size = new Size(847, 59);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(247, 56, 89);
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(847, 59);
            panel2.TabIndex = 3;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 441);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)userImage).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button RegisterButton;
        private TextBox passwordField;
        private PictureBox passwordImage;
        private TextBox loginField;
        private PictureBox userImage;
        private Button closeButton;
        private Label label1;
        private Panel panel2;
        private TextBox lastnameField;
        private TextBox firstnameField;
        private PictureBox pictureBox1;
        private Label surnameLabel;
        private Label nameLabel;
        private Label LoginLabel;
    }
}