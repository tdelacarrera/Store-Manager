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
    public partial class PurchaseUserControl : UserControl
    {
        private ProductController product_controller = new ProductController();
        private PurchaseController purchase_controller = new PurchaseController();
        private AuditController audit_controller = new AuditController();
        private UserController user_controller = new UserController();
        public PurchaseUserControl()
        {
            InitializeComponent();
        }

        private void product_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_text_box.Text = product_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_text_box.Text = product_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void search_text_box_KeyUp(object sender, KeyEventArgs e)
        {
            product_grid.DataSource = product_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + product_grid.RowCount.ToString() + ")";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            String id = id_text_box.Text;
            String amount = amount_text_box.Text.Trim();
            String number = number_text_box.Text.Trim();

            if (id.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
            else if (amount.Trim().Equals("") || number.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (amount.Length > 45 || number.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (!Int32.TryParse(amount, out _))
            {
                MessageBox.Show("La cantida no es valida");

            }
            else if (!Int32.TryParse(number, out _)) {
                MessageBox.Show("El numero de factura no es valido");

            }
            else if (Int32.Parse(amount) < 0 || Int32.Parse(number) < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
            }
            else
            {
                purchase_controller.Insert(new Purchase(0, Int32.Parse(number), User.current_user_id, User.current_user_type));
                audit_controller.Insert(new Audit(0, "Compra ingresada por el usuario " + User.current_user_username));
                product_controller.Update_stock(Int32.Parse(id), Int32.Parse(amount));
                load_grid();
            }
        }
        public void load_grid()
        {
            product_grid.DataSource = product_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + product_grid.RowCount.ToString() + ")";
            if (product_grid.RowCount > 0)
            {
                btn_export.Enabled = true;
            }
            else
            {
                btn_export.Enabled = false;
            }

        }
        public void ClearForm()
        {
            id_text_box.Text = "";
            name_text_box.Text = "";
            amount_text_box.Text = "";
            number_text_box.Text = "";
            product_grid.ClearSelection();
        }
        private void btn_export_Click(object sender, EventArgs e)
        {
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de produtos por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
            Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in product_grid.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in product_grid.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in product_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value.ToString();
                }
            }
            excel.Visible = true;
        }
    }
}
