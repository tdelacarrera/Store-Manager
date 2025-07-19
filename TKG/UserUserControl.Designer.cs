namespace TKG
{
    partial class UserUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_type_combo_box = new System.Windows.Forms.ComboBox();
            this.original_username_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.password_confirm_text_box = new System.Windows.Forms.TextBox();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.rut_text_box = new System.Windows.Forms.TextBox();
            this.username_text_box = new System.Windows.Forms.TextBox();
            this.email_text_box = new System.Windows.Forms.TextBox();
            this.password_text_box = new System.Windows.Forms.TextBox();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.user_grid = new System.Windows.Forms.DataGridView();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.result_number_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_type_combo_box);
            this.groupBox1.Controls.Add(this.original_username_text_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.password_confirm_text_box);
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.rut_text_box);
            this.groupBox1.Controls.Add(this.username_text_box);
            this.groupBox1.Controls.Add(this.email_text_box);
            this.groupBox1.Controls.Add(this.password_text_box);
            this.groupBox1.Controls.Add(this.name_text_box);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antecedentes de Usuario";
            // 
            // user_type_combo_box
            // 
            this.user_type_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.user_type_combo_box.FormattingEnabled = true;
            this.user_type_combo_box.Items.AddRange(new object[] {
            "Administrador",
            "Bodeguero",
            "Usuario"});
            this.user_type_combo_box.Location = new System.Drawing.Point(292, 85);
            this.user_type_combo_box.Name = "user_type_combo_box";
            this.user_type_combo_box.Size = new System.Drawing.Size(117, 23);
            this.user_type_combo_box.TabIndex = 14;
            // 
            // original_username_text_box
            // 
            this.original_username_text_box.Location = new System.Drawing.Point(440, -11);
            this.original_username_text_box.Name = "original_username_text_box";
            this.original_username_text_box.Size = new System.Drawing.Size(45, 21);
            this.original_username_text_box.TabIndex = 18;
            this.original_username_text_box.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Confirmar contraseña";
            // 
            // password_confirm_text_box
            // 
            this.password_confirm_text_box.Location = new System.Drawing.Point(134, 87);
            this.password_confirm_text_box.Name = "password_confirm_text_box";
            this.password_confirm_text_box.PasswordChar = '*';
            this.password_confirm_text_box.Size = new System.Drawing.Size(100, 21);
            this.password_confirm_text_box.TabIndex = 16;
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(504, -11);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(47, 21);
            this.id_text_box.TabIndex = 15;
            this.id_text_box.Visible = false;
            // 
            // rut_text_box
            // 
            this.rut_text_box.Location = new System.Drawing.Point(292, 49);
            this.rut_text_box.Name = "rut_text_box";
            this.rut_text_box.Size = new System.Drawing.Size(109, 21);
            this.rut_text_box.TabIndex = 11;
            // 
            // username_text_box
            // 
            this.username_text_box.Location = new System.Drawing.Point(134, 21);
            this.username_text_box.Name = "username_text_box";
            this.username_text_box.Size = new System.Drawing.Size(98, 21);
            this.username_text_box.TabIndex = 10;
            // 
            // email_text_box
            // 
            this.email_text_box.Location = new System.Drawing.Point(451, 16);
            this.email_text_box.Name = "email_text_box";
            this.email_text_box.Size = new System.Drawing.Size(100, 21);
            this.email_text_box.TabIndex = 9;
            // 
            // password_text_box
            // 
            this.password_text_box.Location = new System.Drawing.Point(134, 54);
            this.password_text_box.Name = "password_text_box";
            this.password_text_box.PasswordChar = '*';
            this.password_text_box.Size = new System.Drawing.Size(98, 21);
            this.password_text_box.TabIndex = 8;
            // 
            // name_text_box
            // 
            this.name_text_box.Location = new System.Drawing.Point(292, 13);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(109, 21);
            this.name_text_box.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(407, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_export);
            this.groupBox2.Controls.Add(this.user_grid);
            this.groupBox2.Controls.Add(this.search_text_box);
            this.groupBox2.Controls.Add(this.result_number_label);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Usuarios";
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(426, 14);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(106, 33);
            this.btn_export.TabIndex = 5;
            this.btn_export.Text = "Exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // user_grid
            // 
            this.user_grid.AllowUserToAddRows = false;
            this.user_grid.AllowUserToDeleteRows = false;
            this.user_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.user_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_grid.Location = new System.Drawing.Point(21, 53);
            this.user_grid.MultiSelect = false;
            this.user_grid.Name = "user_grid";
            this.user_grid.ReadOnly = true;
            this.user_grid.Size = new System.Drawing.Size(511, 133);
            this.user_grid.TabIndex = 4;
            this.user_grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.user_grid_CellMouseUp);
            // 
            // search_text_box
            // 
            this.search_text_box.Location = new System.Drawing.Point(74, 26);
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(100, 21);
            this.search_text_box.TabIndex = 3;
            this.search_text_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_box_KeyUp);
            // 
            // result_number_label
            // 
            this.result_number_label.AutoSize = true;
            this.result_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number_label.Location = new System.Drawing.Point(18, 189);
            this.result_number_label.Name = "result_number_label";
            this.result_number_label.Size = new System.Drawing.Size(88, 13);
            this.result_number_label.TabIndex = 1;
            this.result_number_label.Text = "Total de registros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_modify);
            this.groupBox3.Controls.Add(this.btn_insert);
            this.groupBox3.Location = new System.Drawing.Point(9, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(410, 13);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 37);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = " Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(287, 13);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 37);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(160, 13);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(94, 37);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "        Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(33, 13);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(100, 37);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Ingresar";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // UserUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(580, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_grid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result_number_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox email_text_box;
        private System.Windows.Forms.TextBox password_text_box;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.ComboBox user_type_combo_box;
        private System.Windows.Forms.TextBox rut_text_box;
        private System.Windows.Forms.TextBox username_text_box;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.DataGridView user_grid;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.TextBox id_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password_confirm_text_box;
        private System.Windows.Forms.TextBox original_username_text_box;
        private System.Windows.Forms.Button btn_export;
    }
}
