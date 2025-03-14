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
    public partial class ProductUserControl : UserControl
    {
        private ProductController product_controller = new ProductController();
        private ProductFamilyController product_family_controller = new ProductFamilyController();
        private AuditController audit_controller = new AuditController();
        public ProductUserControl()
        {
            InitializeComponent();
        }
        public void Load_product_family_combo_box_items() {
            var data = new ProductFamilyController().GetAllNames();
            product_family_id_combo_box.Items.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                product_family_id_combo_box.Items.Add(data[i]);
            }
            if (product_family_id_combo_box.Items.Count > 0)
            {
                product_family_id_combo_box.Enabled = true;
            }
            else
            {
                product_family_id_combo_box.Enabled = false;
            }
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            String product_family_id = product_family_id_combo_box.Text.Trim();
            String name = name_text_box.Text.Trim();
            String price = price_text_box.Text.Trim();
            String stock = stock_text_box.Text.Trim();
            if (product_family_id.Trim().Equals("") || name.Trim().Equals("") || price.Trim().Equals("") || stock.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (product_family_id.Length > 45 || name.Length > 45 || price.Length > 45 || stock.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (!Int32.TryParse(stock, out _))
            {
                MessageBox.Show("El stock no es valido");

            }
            else if (!Int32.TryParse(price, out _))
            {
                MessageBox.Show("El precio no es valido");

            }
            else if (Int32.Parse(price) < 0)
            {
                MessageBox.Show("El precio no puede ser negativo");
            }
            else if (Int32.Parse(stock) < 0)
            {
                MessageBox.Show("El stock no puede ser negativo");
            }
            else if (new ProductController().Exists(name))
            {
                MessageBox.Show("El producto ya existe");
            }
            else {
                audit_controller.Insert(new Audit(0, "Ingreso de producto por el usuario " + User.current_user_username));
                product_controller.Insert(new Product(0,Convert.ToInt32(product_family_controller.GetId(product_family_id_combo_box.Text)[0]), name, Int32.Parse(price), Int32.Parse(stock), 1));
                load_grid();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            String id = id_text_box.Text;
            String product_family_id = product_family_id_combo_box.Text.Trim();
            String name = name_text_box.Text.Trim();
            String price = price_text_box.Text.Trim();
            String stock = stock_text_box.Text.Trim();
            String original_name = original_name_text_box.Text.Trim();

            if (id.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
            else if (product_family_id.Trim().Equals("") || name.Trim().Equals("") || price.Trim().Equals("") || stock.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (product_family_id.Length > 45 || name.Length > 45 || price.Length > 45 || stock.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if(!Int32.TryParse(stock, out _))
            {
                MessageBox.Show("El stock no es valido");

            }
            else if (!Int32.TryParse(price, out _))
            {
                MessageBox.Show("El precio no es valido");

            }
            else if (Int32.Parse(price) < 0) {
                MessageBox.Show("El precio no puede ser negativo");
            }
            else if (Int32.Parse(stock) < 0)
            {
                MessageBox.Show("El stock no puede ser negativo");
            }
            else if (product_controller.Exists(name) && !name.Equals(original_name))
            {
                MessageBox.Show("Ya existe un producto con el mismo nombre");
            }
            else {
                audit_controller.Insert(new Audit(0, "Edicion de producto por el usuario " + User.current_user_username));
                product_controller.Modify(new Product(Int32.Parse(id), Convert.ToInt32(product_family_controller.GetId(product_family_id_combo_box.Text)[0]), name, Int32.Parse(price), Int32.Parse(stock), 1));
                load_grid();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            String id = id_text_box.Text;
            if (id.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    audit_controller.Insert(new Audit(0, "Eliminacion de producto por el usuario " + User.current_user_username));
                    product_controller.Delete(Int32.Parse(id));
                    load_grid();
                    ClearForm();
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de productos por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
             Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in products_grid.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in products_grid.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in products_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void products_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id_text_box.Text = products_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_text_box.Text = products_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                original_name_text_box.Text = name_text_box.Text;
                price_text_box.Text = products_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                stock_text_box.Text = products_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                product_family_id_combo_box.SelectedItem = product_family_controller.GetName(Convert.ToInt32(products_grid.Rows[e.RowIndex].Cells[5].Value))[0];

            }
        }

        public void load_grid()
        {
            products_grid.DataSource = product_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + products_grid.RowCount.ToString() + ")";
            if (products_grid.RowCount > 0)
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
            products_grid.DataSource = product_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + products_grid.RowCount.ToString() + ")";
        }
        public void ClearForm()
        {
            id_text_box.Text = "";
            name_text_box.Text = "";
            original_name_text_box.Text = "";
            price_text_box.Text = "";
            stock_text_box.Text = "";
            if (product_family_id_combo_box.Items.Count > 0)
            {
                product_family_id_combo_box.SelectedIndex = 0;
            }
            products_grid.ClearSelection();
        }
    }

}
