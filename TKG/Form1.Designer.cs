namespace TKG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_control = new System.Windows.Forms.TabControl();
            this.user_tab_page = new System.Windows.Forms.TabPage();
            this.userUserControl1 = new TKG.UserUserControl();
            this.product_tab_page = new System.Windows.Forms.TabPage();
            this.productUserControl1 = new TKG.ProductUserControl();
            this.product_family_tab_page = new System.Windows.Forms.TabPage();
            this.productFamilyUserControl1 = new TKG.ProductFamilyUserControl();
            this.puchase_tab_page2 = new System.Windows.Forms.TabPage();
            this.purchaseUserControl1 = new TKG.PurchaseUserControl();
            this.purchase_tab_page = new System.Windows.Forms.TabPage();
            this.purchaseRecords1 = new TKG.PurchaseRecords();
            this.audit_tab_page = new System.Windows.Forms.TabPage();
            this.auditRecords1 = new TKG.AuditRecords();
            this.login_contro_group = new System.Windows.Forms.GroupBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_text_box = new System.Windows.Forms.TextBox();
            this.username_text_box = new System.Windows.Forms.TextBox();
            this.tab_control.SuspendLayout();
            this.user_tab_page.SuspendLayout();
            this.product_tab_page.SuspendLayout();
            this.product_family_tab_page.SuspendLayout();
            this.puchase_tab_page2.SuspendLayout();
            this.purchase_tab_page.SuspendLayout();
            this.audit_tab_page.SuspendLayout();
            this.login_contro_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.user_tab_page);
            this.tab_control.Controls.Add(this.product_tab_page);
            this.tab_control.Controls.Add(this.product_family_tab_page);
            this.tab_control.Controls.Add(this.puchase_tab_page2);
            this.tab_control.Controls.Add(this.purchase_tab_page);
            this.tab_control.Controls.Add(this.audit_tab_page);
            this.tab_control.Location = new System.Drawing.Point(0, 1);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(590, 451);
            this.tab_control.TabIndex = 0;
            // 
            // user_tab_page
            // 
            this.user_tab_page.Controls.Add(this.userUserControl1);
            this.user_tab_page.Location = new System.Drawing.Point(4, 22);
            this.user_tab_page.Name = "user_tab_page";
            this.user_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.user_tab_page.Size = new System.Drawing.Size(582, 425);
            this.user_tab_page.TabIndex = 0;
            this.user_tab_page.Text = "Usuarios";
            this.user_tab_page.UseVisualStyleBackColor = true;
            this.user_tab_page.Enter += new System.EventHandler(this.user_tab_page_Enter);
            // 
            // userUserControl1
            // 
            this.userUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.userUserControl1.Location = new System.Drawing.Point(0, 0);
            this.userUserControl1.Name = "userUserControl1";
            this.userUserControl1.Size = new System.Drawing.Size(584, 425);
            this.userUserControl1.TabIndex = 0;
            // 
            // product_tab_page
            // 
            this.product_tab_page.Controls.Add(this.productUserControl1);
            this.product_tab_page.Location = new System.Drawing.Point(4, 22);
            this.product_tab_page.Name = "product_tab_page";
            this.product_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.product_tab_page.Size = new System.Drawing.Size(582, 425);
            this.product_tab_page.TabIndex = 1;
            this.product_tab_page.Text = "Productos";
            this.product_tab_page.UseVisualStyleBackColor = true;
            this.product_tab_page.Enter += new System.EventHandler(this.product_tab_page_Enter);
            // 
            // productUserControl1
            // 
            this.productUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.productUserControl1.Location = new System.Drawing.Point(0, 0);
            this.productUserControl1.Name = "productUserControl1";
            this.productUserControl1.Size = new System.Drawing.Size(580, 420);
            this.productUserControl1.TabIndex = 0;
            // 
            // product_family_tab_page
            // 
            this.product_family_tab_page.Controls.Add(this.productFamilyUserControl1);
            this.product_family_tab_page.Location = new System.Drawing.Point(4, 22);
            this.product_family_tab_page.Name = "product_family_tab_page";
            this.product_family_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.product_family_tab_page.Size = new System.Drawing.Size(582, 425);
            this.product_family_tab_page.TabIndex = 2;
            this.product_family_tab_page.Text = "Familias de producto";
            this.product_family_tab_page.UseVisualStyleBackColor = true;
            this.product_family_tab_page.Enter += new System.EventHandler(this.product_family_tab_page_Enter);
            // 
            // productFamilyUserControl1
            // 
            this.productFamilyUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.productFamilyUserControl1.Location = new System.Drawing.Point(0, 0);
            this.productFamilyUserControl1.Name = "productFamilyUserControl1";
            this.productFamilyUserControl1.Size = new System.Drawing.Size(584, 425);
            this.productFamilyUserControl1.TabIndex = 0;
            // 
            // puchase_tab_page2
            // 
            this.puchase_tab_page2.Controls.Add(this.purchaseUserControl1);
            this.puchase_tab_page2.Location = new System.Drawing.Point(4, 22);
            this.puchase_tab_page2.Name = "puchase_tab_page2";
            this.puchase_tab_page2.Size = new System.Drawing.Size(582, 425);
            this.puchase_tab_page2.TabIndex = 5;
            this.puchase_tab_page2.Text = "Ingresar compra";
            this.puchase_tab_page2.UseVisualStyleBackColor = true;
            this.puchase_tab_page2.Enter += new System.EventHandler(this.puchase_tab_page2_Enter);
            // 
            // purchaseUserControl1
            // 
            this.purchaseUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.purchaseUserControl1.Location = new System.Drawing.Point(-4, 0);
            this.purchaseUserControl1.Name = "purchaseUserControl1";
            this.purchaseUserControl1.Size = new System.Drawing.Size(590, 425);
            this.purchaseUserControl1.TabIndex = 0;
            // 
            // purchase_tab_page
            // 
            this.purchase_tab_page.Controls.Add(this.purchaseRecords1);
            this.purchase_tab_page.Location = new System.Drawing.Point(4, 22);
            this.purchase_tab_page.Name = "purchase_tab_page";
            this.purchase_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.purchase_tab_page.Size = new System.Drawing.Size(582, 425);
            this.purchase_tab_page.TabIndex = 3;
            this.purchase_tab_page.Text = "Registro de compras de productos";
            this.purchase_tab_page.UseVisualStyleBackColor = true;
            this.purchase_tab_page.Enter += new System.EventHandler(this.purchase_tab_page_Enter);
            // 
            // purchaseRecords1
            // 
            this.purchaseRecords1.BackColor = System.Drawing.SystemColors.Control;
            this.purchaseRecords1.Location = new System.Drawing.Point(-2, 0);
            this.purchaseRecords1.Name = "purchaseRecords1";
            this.purchaseRecords1.Size = new System.Drawing.Size(586, 429);
            this.purchaseRecords1.TabIndex = 0;
            // 
            // audit_tab_page
            // 
            this.audit_tab_page.Controls.Add(this.auditRecords1);
            this.audit_tab_page.Location = new System.Drawing.Point(4, 22);
            this.audit_tab_page.Name = "audit_tab_page";
            this.audit_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.audit_tab_page.Size = new System.Drawing.Size(582, 425);
            this.audit_tab_page.TabIndex = 4;
            this.audit_tab_page.Text = "Registro auditor";
            this.audit_tab_page.UseVisualStyleBackColor = true;
            this.audit_tab_page.Enter += new System.EventHandler(this.audit_tab_page_Enter);
            // 
            // auditRecords1
            // 
            this.auditRecords1.BackColor = System.Drawing.SystemColors.Control;
            this.auditRecords1.Location = new System.Drawing.Point(-4, -1);
            this.auditRecords1.Name = "auditRecords1";
            this.auditRecords1.Size = new System.Drawing.Size(586, 430);
            this.auditRecords1.TabIndex = 0;
            // 
            // login_contro_group
            // 
            this.login_contro_group.BackColor = System.Drawing.SystemColors.Control;
            this.login_contro_group.Controls.Add(this.btn_login);
            this.login_contro_group.Controls.Add(this.label2);
            this.login_contro_group.Controls.Add(this.label1);
            this.login_contro_group.Controls.Add(this.password_text_box);
            this.login_contro_group.Controls.Add(this.username_text_box);
            this.login_contro_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_contro_group.Location = new System.Drawing.Point(128, 94);
            this.login_contro_group.Name = "login_contro_group";
            this.login_contro_group.Size = new System.Drawing.Size(334, 232);
            this.login_contro_group.TabIndex = 1;
            this.login_contro_group.TabStop = false;
            this.login_contro_group.Text = "Iniciar Sesion";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(110, 153);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(94, 39);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Iniciar Sesion";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario";
            // 
            // password_text_box
            // 
            this.password_text_box.Location = new System.Drawing.Point(139, 102);
            this.password_text_box.Name = "password_text_box";
            this.password_text_box.PasswordChar = '*';
            this.password_text_box.Size = new System.Drawing.Size(100, 21);
            this.password_text_box.TabIndex = 1;
            // 
            // username_text_box
            // 
            this.username_text_box.Location = new System.Drawing.Point(139, 50);
            this.username_text_box.Name = "username_text_box";
            this.username_text_box.Size = new System.Drawing.Size(100, 21);
            this.username_text_box.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.login_contro_group);
            this.Controls.Add(this.tab_control);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TKG";
            this.tab_control.ResumeLayout(false);
            this.user_tab_page.ResumeLayout(false);
            this.product_tab_page.ResumeLayout(false);
            this.product_family_tab_page.ResumeLayout(false);
            this.puchase_tab_page2.ResumeLayout(false);
            this.purchase_tab_page.ResumeLayout(false);
            this.audit_tab_page.ResumeLayout(false);
            this.login_contro_group.ResumeLayout(false);
            this.login_contro_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage user_tab_page;
        private System.Windows.Forms.TabPage product_tab_page;
        private System.Windows.Forms.TabPage product_family_tab_page;
        private ProductUserControl productUserControl1;
        private ProductFamilyUserControl productFamilyUserControl1;
        private UserUserControl userUserControl1;
        private System.Windows.Forms.GroupBox login_contro_group;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_text_box;
        private System.Windows.Forms.TextBox username_text_box;
        private System.Windows.Forms.TabPage purchase_tab_page;
        private System.Windows.Forms.TabPage audit_tab_page;
        private PurchaseRecords purchaseRecords1;
        private AuditRecords auditRecords1;
        private System.Windows.Forms.TabPage puchase_tab_page2;
        private PurchaseUserControl purchaseUserControl1;
    }
}