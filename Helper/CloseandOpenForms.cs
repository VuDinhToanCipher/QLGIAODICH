using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGIAODICH.Helper
{
    internal class CloseandOpenForms
    {
        public void Closeform(Form[] form)
        {
            foreach (Form f in form)
            {
                f?.Close();
            }
        }
        public void Openform(Form[] forms, Form form, int index, Panel panel)
        {
            if (forms[index] != null)
            {
                forms[index].Close();
            }
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel.Controls.Add(form);
            form.BringToFront();
            form.Show();
            forms[index] = form;
        }
    }
}
