using System.Windows.Forms;

namespace Inheritance__22._03._24_
{
    public partial class mainForm : Form
    {
        Rectangle rectangle;

        ColorDialog colorDialog;

        bool isDrawed = false;
        bool isBorder = false;

        Color currentColor;

        int width = 100; 
        int height = 100;

        public mainForm()
        {
            InitializeComponent();

            rectangle = new Rectangle(pictureBox);
            colorDialog = new ColorDialog();

            currentColor = Color.White;

            colorDialog.FullOpen = true;
            colorDialog.Color = this.BackColor;

            areaLabel.Hide();
        }

        private void update()
        {
            rectangle.Height = height;
            rectangle.Width = width;
            rectangle.Color = currentColor;

            if (isDrawed) rectangle.Paint();

            areaLabel.Text = "Площадь: " + rectangle.CalculateArea().ToString();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            update(); rectangle.Paint();

            if (borderBox.Checked && !isBorder) rectangle.Draw();

            areaLabel.Show();

            isDrawed = true;
            isBorder = true;
        }

        private void widthBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(widthBox.Text, out width)) widthBox.Text = width.ToString();
            else if (width >= 600) widthBox.Text = "599";

            update();
        }

        private void heightBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(heightBox.Text, out height)) heightBox.Text = height.ToString();
            else if (height >= 300) heightBox.Text = "299";

            update();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel) return;

            this.currentColor = colorDialog.Color;
            if (isDrawed) update();
        }

        private void borderBox_CheckedChanged(object sender, EventArgs e)
        {
            if (isBorder)
            {
                if (borderBox.Checked) rectangle.Draw();
                if (!borderBox.Checked) rectangle.UnDraw();
            }
        }
    }
}
