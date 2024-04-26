namespace CourseProject
{
    partial class mainForm
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
            headerPanel = new Panel();
            headerLabel = new Label();
            mainPanel = new Panel();
            buttonMapPanel = new Panel();
            addEmployeeButton = new Button();
            dataBaseButton = new Button();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            buttonMapPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(723, 60);
            headerPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.Anchor = AnchorStyles.Top;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(723, 63);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Главная";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(buttonMapPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 60);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(723, 208);
            mainPanel.TabIndex = 1;
            // 
            // buttonMapPanel
            // 
            buttonMapPanel.Controls.Add(addEmployeeButton);
            buttonMapPanel.Controls.Add(dataBaseButton);
            buttonMapPanel.Location = new Point(25, 15);
            buttonMapPanel.Name = "buttonMapPanel";
            buttonMapPanel.Size = new Size(673, 173);
            buttonMapPanel.TabIndex = 0;
            // 
            // addEmployeeButton
            // 
            addEmployeeButton.FlatStyle = FlatStyle.Flat;
            addEmployeeButton.Location = new Point(340, 0);
            addEmployeeButton.Name = "addEmployeeButton";
            addEmployeeButton.Size = new Size(333, 172);
            addEmployeeButton.TabIndex = 1;
            addEmployeeButton.Text = "button1";
            addEmployeeButton.UseVisualStyleBackColor = true;
            addEmployeeButton.Click += addEmployeeButton_Click;
            // 
            // dataBaseButton
            // 
            dataBaseButton.FlatStyle = FlatStyle.Flat;
            dataBaseButton.Location = new Point(0, 0);
            dataBaseButton.Name = "dataBaseButton";
            dataBaseButton.Size = new Size(333, 172);
            dataBaseButton.TabIndex = 0;
            dataBaseButton.Text = "button1";
            dataBaseButton.UseVisualStyleBackColor = true;
            dataBaseButton.Click += dataBaseButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 268);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            Name = "mainForm";
            Text = "Сотрудники";
            Load += mainForm_Load;
            headerPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            buttonMapPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Panel mainPanel;
        private Label headerLabel;
        private Panel buttonMapPanel;
        private Button dataBaseButton;
        private Button addEmployeeButton;
    }
}
