using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inheritance__22._03._24_
{
    internal class Rectangle : Figure, PaintAble, DrawAble
    {
        private PictureBox pictureBox;
        private int height = 100, width = 100;

        public Rectangle (PictureBox pictureBox) { 
            this.pictureBox = pictureBox;
        }
        public int Height {
            get { return this.height; }
            set { this.height = value; update(); }
        }
        public int Width { 
            get { return this.width; }
            set { this.width = value; update(); }
        }

        private void update()
        {
            pictureBox.Size = new Size (width, height);
            pictureBox.Location = new Point((650 - this.width) / 2, (343 - this.height) / 2);
        }

        public int CalculateArea()
        {
            return this.height * this.width;
        }

        public void Paint()
        {
            pictureBox.BackColor = this.Color;
        }

        public void Draw()
        {
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        public void UnDraw()
        {
            pictureBox.BorderStyle= BorderStyle.None;
        }
    }
}
