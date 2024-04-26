using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.core
{
    internal class AppDesign
    {
        public Color HeaderColor = Color.FromArgb(140, 185, 189);
        public Color BackgroundColor = Color.FromArgb(222, 252, 255);
        public Color ButtonColor = Color.FromArgb(236, 177, 89);
        public Color ButtonHoverColor = Color.FromArgb(14, 33, 121);
        public Color InnactiveColor = Color.FromArgb(0, 65, 141);
        public Color AccentColor = Color.FromArgb(236, 177, 89);

        public Color TextColor = Color.White;
        public Color TextSecondaryColor = Color.FromArgb(25, 63, 143);

        public Font HeaderFont = new Font("Bahnschrift", 18);
        public Font RegularFont = new Font("Bahnschrift", 13);
    }
}
