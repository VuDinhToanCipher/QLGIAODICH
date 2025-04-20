using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;

namespace QLGIAODICH.Helper
{
    public class Textchange
    {
        public static void changetext(TextBox textbox,Label label)
        {
            if (!textbox.Text.IsNullOrEmpty())
            {
                label.Text = textbox.Text;
            }
            else
            {
                label.Text = "";
            }
        }
    }
}
