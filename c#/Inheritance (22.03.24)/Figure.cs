using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance__22._03._24_
{
    internal class Figure
    {
        public Color Color { get; set; }
        public void ChangeColor(Color newColor)
        {
            Color = newColor;
        }
    }
}
