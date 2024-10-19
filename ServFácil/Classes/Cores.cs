using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServFacil.Classes
{
    internal class Cores
    {
        public static bool passouMouse;
        public static void MudarCor(Button btn)
        {
            if (!passouMouse)
            {
                btn.BackColor = Color.FromArgb(255, 251, 254);
                btn.ForeColor = Color.FromArgb(4, 15, 15);
            }
            else
            {
                btn.BackColor = Color.FromArgb(4, 15, 15);
                btn.ForeColor = Color.FromArgb(255, 251, 254);
            }

        }
    }
}
