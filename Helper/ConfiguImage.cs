using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGIAODICH.Helper
{
    internal static class ConfiguImage
    {
        public static void resizeimg_inbutton(Button button,int x,int y)
        {
            button.Image = new Bitmap(button.Image!, new Size(x, y));
        }
    }
}
