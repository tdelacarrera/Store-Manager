using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TKG
{
    public partial class Form1 : Form
    {
        private AuditController audit_controller = new AuditController();
        private UserController user_controller = new UserController();
        public Form1()
        {
            InitializeComponent();
            tab_control.Hide();
            //tab_control.Show();
            //login_contro_group.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username = username_text_box.Text;
            String password = password_text_box.Text;
            if (username.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios");

            }
            else if (username.Length > 45 || password.Length > 45)
            {
                MessageBox.Show("No se pueden ingresar mas de 45 caracteres");

            }
            else {
                if (user_controller.Login(username, ReturnSHA1(password)))
                {
                    audit_controller.Insert(new Audit(0, "Inicio de sesion por el usuario " + username));
                    User.current_user_username = username;
                    User.current_user_id = user_controller.GetId(username);
                    User.current_user_type = user_controller.GetUserType(username);
        tab_control.Show();
                    login_contro_group.Hide();
                }
                else
                {
                    audit_controller.Insert(new Audit(0, "Intento fallido de inicio de sesion"));
                    MessageBox.Show("El nombre o contraseña no es valido");
                    password_text_box.Text = "";
                }
            }

        }
        private string ReturnSHA1(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] passwordByte = Encoding.ASCII.GetBytes(password);
            byte[] saltByte = sha1.ComputeHash(passwordByte);
            return Convert.ToBase64String(passwordByte);
        }

        private void product_tab_page_Enter(object sender, EventArgs e)
        {
            productUserControl1.Load_product_family_combo_box_items();
            productUserControl1.load_grid();
            productUserControl1.ClearForm();
        }

        private void product_family_tab_page_Enter(object sender, EventArgs e)
        {
            productFamilyUserControl1.load_grid();
            productFamilyUserControl1.ClearForm();

        }

        private void purchase_tab_page_Enter(object sender, EventArgs e)
        {
            purchaseRecords1.load_grid();
            purchaseRecords1.ClearForm();

        }

        private void user_tab_page_Enter(object sender, EventArgs e)
        {
            userUserControl1.load_grid();
            userUserControl1.ClearForm();

        }

        private void audit_tab_page_Enter(object sender, EventArgs e)
        {
            auditRecords1.load_grid();
            auditRecords1.ClearForm();
        }

        private void puchase_tab_page2_Enter(object sender, EventArgs e)
        {
            purchaseUserControl1.load_grid();
            purchaseUserControl1.ClearForm();
        }
    }
}
