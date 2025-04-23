using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGIAODICH.Helper
{
    internal static class dtGridViewconfig
    {
        public static void DTconfig(DataGridView dt)
        {
            dt.BorderStyle = BorderStyle.None;
            dt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dt.RowHeadersVisible = false;
            dt.EnableHeadersVisualStyles = false;
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dt.MultiSelect = false;
            // Header style
            dt.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dt.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Row style
            dt.DefaultCellStyle.BackColor = Color.White;
            dt.DefaultCellStyle.ForeColor = Color.Black;
            dt.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dt.DefaultCellStyle.SelectionForeColor = Color.Black;
            dt.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            //can chinh
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dt.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dt.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
