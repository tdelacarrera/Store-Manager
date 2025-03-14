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
    public partial class ProductFamilyUserControl : UserControl
    {
        private ProductFamilyController product_family_controller = new ProductFamilyController();
        private ProductController product_controller = new ProductController();
        private AuditController audit_controller = new AuditController();
        public ProductFamilyUserControl()
        {
            InitializeComponent();
        }
        private void btn_insert_Click(object sender, EventArgs e)
        {
            String name = name_text_box.Text.Trim();
            if (name.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (name.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (new ProductFamilyController().Exists(name))
            {
                MessageBox.Show("La familia de producto ya existe");
            }
            else {
                audit_controller.Insert(new Audit(0, "Ingreso de familia de producto por el usuario "+ User.current_user_username));
                product_family_controller.Insert(new ProductFamily(0, name, 1));
                load_grid();
            }
        }
        private void btn_modify_Click(object sender, EventArgs e)
        {
            String id = id_text_box.Text;
            String name = name_text_box.Text.Trim();
            String original_name = original_name_text_box.Text.Trim();

            if (id.Trim().Equals("")) {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
            else if (name.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (name.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (product_family_controller.Exists(name) && !name.Equals(original_name))
            {
                MessageBox.Show("Ya existe una familia de producto con el mismo nombre");
            }
            else {
                audit_controller.Insert(new Audit(0, "Edicion de familia de producto por el usuario "+ User.current_user_username));
                product_family_controller.Modify(new ProductFamily(Int32.Parse(id), name, 1));
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
            else if (product_controller.ExistsByProductFamilyId(Int32.Parse(id))) {
                MessageBox.Show("No se puede eliminar la familia de producto dado que existen productos asociados a esta");
            }
            else {
                DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    audit_controller.Insert(new Audit(0, "Eliminacion de familia de producto por el usuario " + User.current_user_username));
                    product_family_controller.Delete(Int32.Parse(id));
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
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de familias de productos por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
            Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in product_family_grid.Columns) 
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in product_family_grid.Rows) 
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in product_family_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void product_family_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                id_text_box.Text = product_family_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                name_text_box.Text = product_family_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                original_name_text_box.Text = name_text_box.Text;
            }
        }


        public void load_grid()
        {
            product_family_grid.DataSource = product_family_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + product_family_grid.RowCount.ToString() + ")";
            if (product_family_grid.RowCount > 0)
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
            product_family_grid.DataSource = product_family_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + product_family_grid.RowCount.ToString() + ")";
        }
        public void ClearForm()
        {
            id_text_box.Text = "";
            product_family_grid.Text = "";
            name_text_box.Text = "";
            original_name_text_box.Text = "";
            product_family_grid.ClearSelection();
            
        }
    }
}
