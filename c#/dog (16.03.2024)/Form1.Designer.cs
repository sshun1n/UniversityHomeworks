namespace dawg
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            barkButton = new Button();
            barkLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 300);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // barkButton
            // 
            barkButton.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            barkButton.Location = new Point(124, 372);
            barkButton.Name = "barkButton";
            barkButton.Size = new Size(250, 50);
            barkButton.TabIndex = 1;
            barkButton.Text = "Лаять";
            barkButton.UseVisualStyleBackColor = true;
            barkButton.Click += button1_Click;
            // 
            // barkLabel
            // 
            barkLabel.AutoSize = true;
            barkLabel.Location = new Point(208, 336);
            barkLabel.Name = "barkLabel";
            barkLabel.Size = new Size(38, 15);
            barkLabel.TabIndex = 2;
            barkLabel.Text = "label1";
            barkLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(484, 515);
            Controls.Add(barkLabel);
            Controls.Add(barkButton);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(500, 550);
            MinimumSize = new Size(500, 550);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button barkButton;
        private Label barkLabel;
    }
}
