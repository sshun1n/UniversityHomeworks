namespace CourseProject
{
    partial class dataForm
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
            toolsPanel = new Panel();
            searchButton = new Button();
            searchBox = new TextBox();
            searchLabel = new Label();
            gridPanel = new Panel();
            errorLabel = new Label();
            dataGrid = new DataGridView();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            toolsPanel.SuspendLayout();
            gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(backButton);
            headerPanel.Controls.Add(headerLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(920, 63);
            headerPanel.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(0, 20);
            backButton.Name = "backButton";
            backButton.Size = new Size(27, 23);
            backButton.TabIndex = 1;
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // headerLabel
            // 
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Location = new Point(0, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(920, 63);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Текущая база данных";
            headerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(toolsPanel);
            mainPanel.Controls.Add(gridPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 63);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(25);
            mainPanel.Size = new Size(920, 387);
            mainPanel.TabIndex = 1;
            // 
            // toolsPanel
            // 
            toolsPanel.Controls.Add(searchButton);
            toolsPanel.Controls.Add(searchBox);
            toolsPanel.Controls.Add(searchLabel);
            toolsPanel.Dock = DockStyle.Top;
            toolsPanel.Location = new Point(25, 25);
            toolsPanel.Name = "toolsPanel";
            toolsPanel.Padding = new Padding(25, 5, 5, 5);
            toolsPanel.Size = new Size(870, 41);
            toolsPanel.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Cursor = Cursors.Hand;
            searchButton.Dock = DockStyle.Left;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Image = Resource.searchicon;
            searchButton.Location = new Point(258, 5);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(28, 31);
            searchButton.TabIndex = 3;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchBox
            // 
            searchBox.Dock = DockStyle.Left;
            searchBox.Location = new Point(70, 5);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(188, 31);
            searchBox.TabIndex = 2;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Dock = DockStyle.Left;
            searchLabel.Location = new Point(25, 5);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(45, 15);
            searchLabel.TabIndex = 1;
            searchLabel.Text = "Поиск:";
            // 
            // gridPanel
            // 
            gridPanel.Controls.Add(errorLabel);
            gridPanel.Controls.Add(dataGrid);
            gridPanel.Dock = DockStyle.Bottom;
            gridPanel.Location = new Point(25, 69);
            gridPanel.Name = "gridPanel";
            gridPanel.Padding = new Padding(3);
            gridPanel.Size = new Size(870, 293);
            gridPanel.TabIndex = 0;
            // 
            // errorLabel
            // 
            errorLabel.Dock = DockStyle.Fill;
            errorLabel.Location = new Point(3, 3);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(864, 287);
            errorLabel.TabIndex = 1;
            errorLabel.Text = "label1";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGrid
            // 
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(3, 3);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(864, 287);
            dataGrid.TabIndex = 0;
            dataGrid.CellClick += dataGrid_CellClick;
            // 
            // dataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 450);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            Name = "dataForm";
            Text = "dataForm";
            FormClosing += dataForm_FormClosing;
            Load += dataForm_Load;
            headerPanel.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            toolsPanel.ResumeLayout(false);
            toolsPanel.PerformLayout();
            gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label headerLabel;
        private Panel mainPanel;
        private Panel gridPanel;
        private Panel toolsPanel;
        private DataGridView dataGrid;
        private Button backButton;
        private Label searchLabel;
        private TextBox searchBox;
        private Button searchButton;
        private Label errorLabel;
    }
}