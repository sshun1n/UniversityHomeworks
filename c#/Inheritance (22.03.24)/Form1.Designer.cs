namespace Inheritance__22._03._24_
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
            lowerPanel = new Panel();
            pictureBox = new PictureBox();
            drawButton = new Button();
            widthBox = new TextBox();
            WidthLabel = new Label();
            panel1 = new Panel();
            borderBox = new CheckBox();
            borderLabel = new Label();
            colorLabel = new Label();
            colorButton = new Button();
            HeightLabel = new Label();
            heightBox = new TextBox();
            areaLabel = new Label();
            lowerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lowerPanel
            // 
            lowerPanel.Controls.Add(areaLabel);
            lowerPanel.Controls.Add(pictureBox);
            lowerPanel.Dock = DockStyle.Bottom;
            lowerPanel.Location = new Point(0, 120);
            lowerPanel.Name = "lowerPanel";
            lowerPanel.Size = new Size(650, 400);
            lowerPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(275, 134);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 50);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // drawButton
            // 
            drawButton.BackColor = Color.FromArgb(55, 55, 55);
            drawButton.Cursor = Cursors.Hand;
            drawButton.FlatAppearance.BorderSize = 0;
            drawButton.FlatStyle = FlatStyle.Flat;
            drawButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            drawButton.ForeColor = Color.White;
            drawButton.Location = new Point(222, 50);
            drawButton.Name = "drawButton";
            drawButton.Size = new Size(205, 64);
            drawButton.TabIndex = 3;
            drawButton.Text = "Нарисовать";
            drawButton.UseVisualStyleBackColor = false;
            drawButton.Click += drawButton_Click;
            // 
            // widthBox
            // 
            widthBox.BackColor = Color.FromArgb(33, 33, 33);
            widthBox.BorderStyle = BorderStyle.None;
            widthBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            widthBox.ForeColor = Color.White;
            widthBox.Location = new Point(97, 12);
            widthBox.Name = "widthBox";
            widthBox.Size = new Size(61, 20);
            widthBox.TabIndex = 4;
            widthBox.Text = "100";
            widthBox.TextAlign = HorizontalAlignment.Center;
            widthBox.TextChanged += widthBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WidthLabel.ForeColor = Color.White;
            WidthLabel.Location = new Point(24, 12);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(70, 20);
            WidthLabel.TabIndex = 5;
            WidthLabel.Text = "Ширина:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(borderBox);
            panel1.Controls.Add(borderLabel);
            panel1.Controls.Add(colorLabel);
            panel1.Controls.Add(colorButton);
            panel1.Controls.Add(HeightLabel);
            panel1.Controls.Add(heightBox);
            panel1.Controls.Add(WidthLabel);
            panel1.Controls.Add(widthBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 44);
            panel1.TabIndex = 6;
            // 
            // borderBox
            // 
            borderBox.AutoSize = true;
            borderBox.Location = new Point(605, 17);
            borderBox.Name = "borderBox";
            borderBox.Size = new Size(15, 14);
            borderBox.TabIndex = 11;
            borderBox.UseVisualStyleBackColor = true;
            borderBox.CheckedChanged += borderBox_CheckedChanged;
            // 
            // borderLabel
            // 
            borderLabel.AutoSize = true;
            borderLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            borderLabel.ForeColor = Color.White;
            borderLabel.Location = new Point(532, 12);
            borderLabel.Name = "borderLabel";
            borderLabel.Size = new Size(72, 20);
            borderLabel.TabIndex = 10;
            borderLabel.Text = "Обводка:";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            colorLabel.ForeColor = Color.White;
            colorLabel.Location = new Point(334, 12);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(45, 20);
            colorLabel.TabIndex = 9;
            colorLabel.Text = "Цвет:";
            // 
            // colorButton
            // 
            colorButton.BackColor = Color.FromArgb(33, 33, 33);
            colorButton.Cursor = Cursors.Hand;
            colorButton.FlatAppearance.BorderSize = 0;
            colorButton.FlatStyle = FlatStyle.Flat;
            colorButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            colorButton.ForeColor = Color.White;
            colorButton.Location = new Point(380, 7);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(127, 29);
            colorButton.TabIndex = 8;
            colorButton.Text = "Выбрать цвет";
            colorButton.TextAlign = ContentAlignment.TopCenter;
            colorButton.UseVisualStyleBackColor = false;
            colorButton.Click += colorButton_Click;
            // 
            // HeightLabel
            // 
            HeightLabel.AutoSize = true;
            HeightLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HeightLabel.ForeColor = Color.White;
            HeightLabel.Location = new Point(180, 12);
            HeightLabel.Name = "HeightLabel";
            HeightLabel.Size = new Size(62, 20);
            HeightLabel.TabIndex = 7;
            HeightLabel.Text = "Высота:";
            // 
            // heightBox
            // 
            heightBox.BackColor = Color.FromArgb(33, 33, 33);
            heightBox.BorderStyle = BorderStyle.None;
            heightBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            heightBox.ForeColor = Color.White;
            heightBox.Location = new Point(246, 12);
            heightBox.Name = "heightBox";
            heightBox.Size = new Size(61, 20);
            heightBox.TabIndex = 6;
            heightBox.Text = "100";
            heightBox.TextAlign = HorizontalAlignment.Center;
            heightBox.TextChanged += heightBox_TextChanged;
            // 
            // areaLabel
            // 
            areaLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            areaLabel.ForeColor = Color.White;
            areaLabel.Location = new Point(222, 371);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(205, 23);
            areaLabel.TabIndex = 1;
            areaLabel.Text = "Площадь: 0000";
            areaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(650, 520);
            Controls.Add(panel1);
            Controls.Add(drawButton);
            Controls.Add(lowerPanel);
            MaximumSize = new Size(666, 555);
            MinimumSize = new Size(666, 555);
            Name = "mainForm";
            Text = "inheritance";
            lowerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel lowerPanel;
        private Button drawButton;
        private PictureBox pictureBox;
        private TextBox widthBox;
        private Label WidthLabel;
        private Panel panel1;
        private Label HeightLabel;
        private TextBox heightBox;
        private Button colorButton;
        private Label colorLabel;
        private CheckBox borderBox;
        private Label borderLabel;
        private Label areaLabel;
    }
}
