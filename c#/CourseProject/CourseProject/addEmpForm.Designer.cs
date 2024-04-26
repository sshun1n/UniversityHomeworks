namespace CourseProject
{
    partial class addEmpForm
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
            headerPanel = new Panel();
            backButton = new Button();
            headerLabel = new Label();
            mainPanel = new Panel();
            panel1 = new Panel();
            addButton = new Button();
            salaryLabel = new Label();
            salaryBox = new TextBox();
            roleLabel = new Label();
            roleBox = new TextBox();
            middleNameLabel = new Label();
            middleNameBox = new TextBox();
            lastNameLabel = new Label();
            lastNameBox = new TextBox();
            firstNameLabel = new Label();
            firstNameBox = new TextBox();
            hoursWorkedLabel = new Label();
            hoursWorkedBox = new TextBox();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(backButton);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(800, 63);
            headerPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(0, 20);
            backButton.Name = "backButton";
            backButton.Size = new Size(27, 23);
            backButton.TabIndex = 3;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(800, 63);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Добавить сотрудника";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 63);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(25);
            mainPanel.Size = new Size(800, 271);
            mainPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(hoursWorkedLabel);
            panel1.Controls.Add(hoursWorkedBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(salaryLabel);
            panel1.Controls.Add(salaryBox);
            panel1.Controls.Add(roleLabel);
            panel1.Controls.Add(roleBox);
            panel1.Controls.Add(middleNameLabel);
            panel1.Controls.Add(middleNameBox);
            panel1.Controls.Add(lastNameLabel);
            panel1.Controls.Add(lastNameBox);
            panel1.Controls.Add(firstNameLabel);
            panel1.Controls.Add(firstNameBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 221);
            panel1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(302, 172);
            addButton.Name = "addButton";
            addButton.Size = new Size(138, 23);
            addButton.TabIndex = 10;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(345, 98);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(41, 15);
            salaryLabel.TabIndex = 9;
            salaryLabel.Text = "Оклад";
            // 
            // salaryBox
            // 
            salaryBox.Location = new Point(253, 122);
            salaryBox.Multiline = true;
            salaryBox.Name = "salaryBox";
            salaryBox.Size = new Size(245, 30);
            salaryBox.TabIndex = 8;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(70, 98);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(69, 15);
            roleLabel.TabIndex = 7;
            roleLabel.Text = "Должность";
            // 
            // roleBox
            // 
            roleBox.Location = new Point(0, 122);
            roleBox.Multiline = true;
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(245, 30);
            roleBox.TabIndex = 6;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(584, 3);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(58, 15);
            middleNameLabel.TabIndex = 5;
            middleNameLabel.Text = "Отчество";
            // 
            // middleNameBox
            // 
            middleNameBox.Location = new Point(505, 27);
            middleNameBox.Multiline = true;
            middleNameBox.Name = "middleNameBox";
            middleNameBox.Size = new Size(245, 30);
            middleNameBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(329, 3);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(58, 15);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Фамилия";
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(253, 27);
            lastNameBox.Multiline = true;
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(245, 30);
            lastNameBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(100, 3);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(31, 15);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "Имя";
            // 
            // firstNameBox
            // 
            firstNameBox.Location = new Point(0, 27);
            firstNameBox.Multiline = true;
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(245, 30);
            firstNameBox.TabIndex = 0;
            // 
            // hoursWorkedLabel
            // 
            hoursWorkedLabel.AutoSize = true;
            hoursWorkedLabel.Location = new Point(551, 98);
            hoursWorkedLabel.Name = "hoursWorkedLabel";
            hoursWorkedLabel.Size = new Size(115, 15);
            hoursWorkedLabel.TabIndex = 12;
            hoursWorkedLabel.Text = "Отработанно часов";
            // 
            // hoursWorkedBox
            // 
            hoursWorkedBox.Location = new Point(505, 122);
            hoursWorkedBox.Multiline = true;
            hoursWorkedBox.Name = "hoursWorkedBox";
            hoursWorkedBox.Size = new Size(245, 30);
            hoursWorkedBox.TabIndex = 11;
            // 
            // addEmpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            Name = "addEmpForm";
            Text = "addEmpForm";
            FormClosing += addEmpForm_FormClosing;
            Load += addEmpForm_Load;
            headerPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel mainPanel;
        private Button backButton;
        private Label headerLabel;
        private Panel panel1;
        private TextBox firstNameBox;
        private Label middleNameLabel;
        private TextBox middleNameBox;
        private Label lastNameLabel;
        private TextBox lastNameBox;
        private Label firstNameLabel;
        private Label salaryLabel;
        private TextBox salaryBox;
        private Label roleLabel;
        private TextBox roleBox;
        private Button addButton;
        private Label hoursWorkedLabel;
        private TextBox hoursWorkedBox;
    }
}