using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace TKG
{
    public partial class UserUserControl : UserControl
    {
        private UserController user_controller = new UserController();
        private AuditController audit_controller = new AuditController();
        public UserUserControl()
        {
            InitializeComponent();
            load_grid();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            String name = name_text_box.Text.Trim();
            String email = email_text_box.Text.Trim();
            String rut = rut_text_box.Text.Trim();
            String username = username_text_box.Text.Trim();
            String password = password_text_box.Text;
            String password_confirm = password_confirm_text_box.Text;
            int user_type_id = 0;
            switch (user_type_combo_box.Text)
            {
                case "Administrador":
                    user_type_id = 1;
                    break;
                case "Bodeguero":
                    user_type_id = 2;
                    break;
                case "Usuario":
                    user_type_id = 3;
                    break;
            }
            if (name.Trim().Equals("") || email.Trim().Equals("") || rut.Trim().Equals("") || username.Trim().Equals("") || password.Trim().Equals("") || password_confirm.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (name.Length > 45 || email.Length > 45 || rut.Trim().Length > 45 || username.Length > 45 || password.Trim().Length > 45 || password_confirm.Trim().Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (!validateRut(rut))
            {
                MessageBox.Show("El rut no es valido");
            }
            else if (!validateEmail(email))
            {
                MessageBox.Show("El email no es valido");
            }
            else if (user_controller.Exists(username))
            {
                MessageBox.Show("El nombre de usuario elegido ya esta ocupado");
            }
            else if (!password.Equals(password_confirm)) {
                MessageBox.Show("Las contraseñas no coinciden");
                password_text_box.Text = "";
                password_confirm_text_box.Text = "";
            }
            else {
                audit_controller.Insert(new Audit(0, "Ingreso de usuario por el usuario " + User.current_user_username));
                user_controller.Insert(new User(0, name, email, rut, username, ReturnSHA1(password), 1, user_type_id));
                load_grid();
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            String id = id_text_box.Text;
            String name = name_text_box.Text.Trim();
            String email = email_text_box.Text.Trim();
            String rut = rut_text_box.Text.Trim();
            String username = username_text_box.Text.Trim();
            String original_username = original_username_text_box.Text.Trim();
            String password = password_text_box.Text;
            String password_confirm = password_confirm_text_box.Text;
            int user_type_id = 0;
            switch (user_type_combo_box.Text) {
                case "Administrador":
                    user_type_id = 1;
                break;
                case "Bodeguero":
                    user_type_id = 2;
                    break;
                case "Usuario":
                    user_type_id = 3;
                    break;
            }

            if (id.Trim().Equals(""))
            {
                MessageBox.Show("No se ha seleccionado ningun registro");
            }
            else if (name.Trim().Equals("") || email.Trim().Equals("") || rut.Trim().Equals("") || username.Trim().Equals("") || password.Trim().Equals("") || password_confirm.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (name.Length > 45 || email.Length > 45 || rut.Trim().Length > 45 || username.Length > 45 || password.Trim().Length > 45 || password_confirm.Trim().Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");
            }
            else if (!validateRut(rut))
            {
                MessageBox.Show("El rut no es valido");
            }
            else if (!validateEmail(email))
            {
                MessageBox.Show("El email no es valido");
            }
            else if (user_controller.Exists(username) && !username.Equals(original_username))
            {
                MessageBox.Show("El nombre de usuario elegido ya esta ocupado");
            }
            else if (!password.Equals(password_confirm))
            {
                MessageBox.Show("Las contraseñas no coinciden");
                password_text_box.Text = "";
                password_confirm_text_box.Text = "";
            }
            else
            {
                if (Int32.Parse(id) == User.current_user_id) {
                    User.current_user_username = username;
                    User.current_user_type = user_type_id;
                }
                audit_controller.Insert(new Audit(0, "Edicion de usuario por el usuario " + User.current_user_username));
                user_controller.Modify(new User(Int32.Parse(id), name, email, rut, username, ReturnSHA1(password), 1, user_type_id));
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
                    audit_controller.Insert(new Audit(0, "Eliminacion de usuario por el usuario " + User.current_user_username));
                    user_controller.Delete(Int32.Parse(id));
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
            audit_controller.Insert(new Audit(0, "Exportacion de tabla de usuarios por el usuario " + User.current_user_username));
            Microsoft.Office.Interop.Excel.Application excel = new
             Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int IndiceColumna = 0;
            foreach (DataGridViewColumn col in user_grid.Columns)
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;
            }
            int IndeceFila = 0;
            foreach (DataGridViewRow row in user_grid.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;
                foreach (DataGridViewColumn col in user_grid.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }

        private void user_grid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                password_text_box.Text = "";
                password_confirm_text_box.Text = "";
                id_text_box.Text = user_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
                username_text_box.Text = user_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
                name_text_box.Text = user_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
                email_text_box.Text = user_grid.Rows[e.RowIndex].Cells[3].Value.ToString();
                rut_text_box.Text = user_grid.Rows[e.RowIndex].Cells[4].Value.ToString();
                original_username_text_box.Text = username_text_box.Text;
                switch (user_grid.Rows[e.RowIndex].Cells[6].Value) {
                    case 1: user_type_combo_box.SelectedItem = "Administrador";  break;
                    case 2: user_type_combo_box.SelectedItem = "Bodeguero"; break;
                    case 3: user_type_combo_box.SelectedItem = "Usuario"; break;
                }
            }
        }
        public void load_grid()
        {
            user_grid.DataSource = user_controller.GetAllRows();
            result_number_label.Text = "Total de registros(" + user_grid.RowCount.ToString() + ")";
            if (user_grid.RowCount > 0)
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
            user_grid.DataSource = user_controller.filter(search_text_box.Text);
            result_number_label.Text = "Total de registros(" + user_grid.RowCount.ToString() + ")";
        }
        public void ClearForm()
        {
            id_text_box.Text = "";
            name_text_box.Text = "";
            email_text_box.Text = "";
            rut_text_box.Text = "";
            username_text_box.Text = "";
            original_username_text_box.Text = "";
            password_text_box.Text = "";
            password_confirm_text_box.Text = "";
            user_grid.ClearSelection();
            user_type_combo_box.SelectedItem = "Usuario";
        }
        private bool validateRut(string rut)
        {
            if (rut.Length == 0)
            {
                return false;
            }
            rut = rut.Replace(".", "").ToUpper();
            Regex expression = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expression.IsMatch(rut))
            {
                return false;
            }
            char[] charSplit = { '-' };
            string[] rutTemp = rut.Split(charSplit);
            if (dv != Digit(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }
        private string Digit(int rut)
        {
            int sum = 0;
            int multiplier = 1;
            while (rut != 0)
            {
                multiplier++;
                if (multiplier == 8)
                    multiplier = 2;
                sum += (rut % 10) * multiplier;
                rut = rut / 10;
            }
            sum = 11 - (sum % 11);
            if (sum == 11)
            {
                return "0";
            }
            else if (sum == 10)
            {
                return "K";
            }
            else
            {
                return sum.ToString();
            }
        }
        private string ReturnSHA1(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordByte = Encoding.ASCII.GetBytes(password);
            byte[] saltByte = sha1.ComputeHash(passwordByte);
            return Convert.ToBase64String(passwordByte);
        }
        public static bool validateEmail(String email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
