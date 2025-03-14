using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKG
{
    public partial class PurchaseRecords : UserControl
    {

        private PurchaseController purchase_controller = new PurchaseController();
        private AuditController audit_controller = new AuditController();

        public PurchaseRecords()
        {
            InitializeComponent();
        }


        private void purchase_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_text_box.Text = purchase_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

        }

        private void search_text_box_KeyUp(object sender, KeyEventArgs e)
        {
            purchase_grid.DataSource = purchase_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + purchase_grid.RowCount.ToString() + ")";

        }
        public void load_grid()
        {
            purchase_grid.DataSource = purchase_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + purchase_grid.RowCount.ToString() + ")";
            if (purchase_grid.RowCount > 0)
            {
                btn_export2.Enabled = true;
            }
            else
            {
                btn_export2.Enabled = false;
            }

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de compras por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
             Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in purchase_grid.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in purchase_grid.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in purchase_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value.ToString();
                }
            }
            excel.Visible = true;
        }
        public void ClearForm() {
            search_text_box.Text = "";
        }
    }
}
