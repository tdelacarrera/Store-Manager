namespace TKG
{
    partial class ProductUserControl
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
            this.original_name_text_box = new System.Windows.Forms.TextBox();
            this.product_family_id_combo_box = new System.Windows.Forms.ComboBox();
            this.product_family_id_label = new System.Windows.Forms.Label();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.stock_text_box = new System.Windows.Forms.TextBox();
            this.price_text_box = new System.Windows.Forms.TextBox();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.products_grid = new System.Windows.Forms.DataGridView();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.result_number_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.original_name_text_box);
            this.groupBox1.Controls.Add(this.product_family_id_combo_box);
            this.groupBox1.Controls.Add(this.product_family_id_label);
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.stock_text_box);
            this.groupBox1.Controls.Add(this.price_text_box);
            this.groupBox1.Controls.Add(this.name_text_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antecedentes de Producto";
            // 
            // original_name_text_box
            // 
            this.original_name_text_box.Location = new System.Drawing.Point(424, 2);
            this.original_name_text_box.Name = "original_name_text_box";
            this.original_name_text_box.Size = new System.Drawing.Size(54, 21);
            this.original_name_text_box.TabIndex = 11;
            this.original_name_text_box.Visible = false;
            // 
            // product_family_id_combo_box
            // 
            this.product_family_id_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_family_id_combo_box.FormattingEnabled = true;
            this.product_family_id_combo_box.Location = new System.Drawing.Point(371, 29);
            this.product_family_id_combo_box.Name = "product_family_id_combo_box";
            this.product_family_id_combo_box.Size = new System.Drawing.Size(121, 23);
            this.product_family_id_combo_box.TabIndex = 10;
            // 
            // product_family_id_label
            // 
            this.product_family_id_label.AutoSize = true;
            this.product_family_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_family_id_label.Location = new System.Drawing.Point(250, 34);
            this.product_family_id_label.Name = "product_family_id_label";
            this.product_family_id_label.Size = new System.Drawing.Size(104, 13);
            this.product_family_id_label.TabIndex = 9;
            this.product_family_id_label.Text = "Familia de productos";
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(491, 0);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(47, 21);
            this.id_text_box.TabIndex = 8;
            this.id_text_box.Visible = false;
            // 
            // stock_text_box
            // 
            this.stock_text_box.Location = new System.Drawing.Point(371, 66);
            this.stock_text_box.Name = "stock_text_box";
            this.stock_text_box.Size = new System.Drawing.Size(100, 21);
            this.stock_text_box.TabIndex = 6;
            // 
            // price_text_box
            // 
            this.price_text_box.Location = new System.Drawing.Point(135, 61);
            this.price_text_box.Name = "price_text_box";
            this.price_text_box.Size = new System.Drawing.Size(100, 21);
            this.price_text_box.TabIndex = 5;
            // 
            // name_text_box
            // 
            this.name_text_box.Location = new System.Drawing.Point(135, 29);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.Size = new System.Drawing.Size(100, 21);
            this.name_text_box.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(319, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_modify);
            this.groupBox2.Controls.Add(this.btn_insert);
            this.groupBox2.Location = new System.Drawing.Point(3, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btn_clear
            // 
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.Location = new System.Drawing.Point(424, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(106, 48);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(295, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 48);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Eliminar";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modify
            // 
            this.btn_modify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modify.Location = new System.Drawing.Point(159, 19);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(113, 48);
            this.btn_modify.TabIndex = 1;
            this.btn_modify.Text = "  Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(35, 19);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(105, 48);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Ingresar";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_export);
            this.groupBox3.Controls.Add(this.products_grid);
            this.groupBox3.Controls.Add(this.search_text_box);
            this.groupBox3.Controls.Add(this.result_number_label);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 211);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Productos";
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(446, 15);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(92, 31);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "     Exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // products_grid
            // 
            this.products_grid.AllowUserToAddRows = false;
            this.products_grid.AllowUserToDeleteRows = false;
            this.products_grid.AllowUserToOrderColumns = true;
            this.products_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.products_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.products_grid.Location = new System.Drawing.Point(25, 52);
            this.products_grid.MultiSelect = false;
            this.products_grid.Name = "products_grid";
            this.products_grid.ReadOnly = true;
            this.products_grid.Size = new System.Drawing.Size(513, 134);
            this.products_grid.TabIndex = 3;
            this.products_grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.products_grid_CellMouseUp);
            // 
            // search_text_box
            // 
            this.search_text_box.Location = new System.Drawing.Point(74, 24);
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(100, 21);
            this.search_text_box.TabIndex = 2;
            this.search_text_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_box_KeyUp);
            // 
            // result_number_label
            // 
            this.result_number_label.AutoSize = true;
            this.result_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number_label.Location = new System.Drawing.Point(19, 189);
            this.result_number_label.Name = "result_number_label";
            this.result_number_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result_number_label.Size = new System.Drawing.Size(88, 13);
            this.result_number_label.TabIndex = 1;
            this.result_number_label.Text = "Total de registros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Buscar";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(580, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.products_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox product_family_id_combo_box;
        private System.Windows.Forms.Label product_family_id_label;
        private System.Windows.Forms.TextBox id_text_box;
        private System.Windows.Forms.TextBox stock_text_box;
        private System.Windows.Forms.TextBox price_text_box;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.DataGridView products_grid;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.Label result_number_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox original_name_text_box;
    }
}
