using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGIAODICH.Helper
{
    internal static class SuakichcoPanel
    {
        public static void Fix(float width,float height,Panel panel,Form form,int loca_x,int loca_y)
        {
            int Width = (int)(form.ClientRectangle.Width * width);
            int Height = (int)(form.ClientRectangle.Height * height);
            panel.Location = new Point(loca_x,loca_y);
            panel.Size = new Size(Width,Height);
        }
    }
}
