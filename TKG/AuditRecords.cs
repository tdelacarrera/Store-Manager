using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace TKG
{
    public partial class AuditRecords : UserControl
    {
        private AuditController audit_controller = new AuditController();
        public AuditRecords()
        {
            InitializeComponent();
        }

        private void audit_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_text_box.Text = audit_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de auditoria por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
            Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in audit_grid.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in audit_grid.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in audit_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value.ToString();
                }
            }
            excel.Visible = true;
        }
        public void ClearForm()
        {
            search_text_box.Text = "";
            audit_grid.ClearSelection();
        }
        public void load_grid()
        {
            audit_grid.DataSource = audit_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + audit_grid.RowCount.ToString() + ")";
            if (audit_grid.RowCount > 0)
            {
                btn_export.Enabled = true;
            }
            else
            {
                btn_export.Enabled = false;
            }

        }

        private void search_text_box_KeyUp(object sender, KeyEventArgs e)
        {
            audit_grid.DataSource = audit_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + audit_grid.RowCount.ToString() + ")";

        }
    }
}
