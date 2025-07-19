namespace TKG
{
    partial class PurchaseUserControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.number_text_box = new System.Windows.Forms.TextBox();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.amount_text_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name_text_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.result_number_label = new System.Windows.Forms.Label();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.number_text_box);
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.amount_text_box);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.name_text_box);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar una compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de factura ";
            // 
            // number_text_box
            // 
            this.number_text_box.Location = new System.Drawing.Point(129, 52);
            this.number_text_box.Name = "number_text_box";
            this.number_text_box.Size = new System.Drawing.Size(100, 21);
            this.number_text_box.TabIndex = 7;
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(448, 0);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(55, 21);
            this.id_text_box.TabIndex = 6;
            this.id_text_box.Visible = false;
            // 
            // amount_text_box
            // 
            this.amount_text_box.Location = new System.Drawing.Point(300, 16);
            this.amount_text_box.Name = "amount_text_box";
            this.amount_text_box.Size = new System.Drawing.Size(100, 21);
            this.amount_text_box.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // name_text_box
            // 
            this.name_text_box.Enabled = false;
            this.name_text_box.Location = new System.Drawing.Point(129, 16);
            this.name_text_box.Name = "name_text_box";
            this.name_text_box.ReadOnly = true;
            this.name_text_box.Size = new System.Drawing.Size(100, 21);
            this.name_text_box.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre del producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_insert);
            this.groupBox2.Location = new System.Drawing.Point(19, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_insert
            // 
            this.btn_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_insert.Location = new System.Drawing.Point(185, 19);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(150, 33);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "Ingresar compra";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_export);
            this.groupBox3.Controls.Add(this.result_number_label);
            this.groupBox3.Controls.Add(this.search_text_box);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.product_grid);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 212);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de productos";
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(425, 18);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(97, 33);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "       Exportar";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // result_number_label
            // 
            this.result_number_label.AutoSize = true;
            this.result_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number_label.Location = new System.Drawing.Point(26, 193);
            this.result_number_label.Name = "result_number_label";
            this.result_number_label.Size = new System.Drawing.Size(88, 13);
            this.result_number_label.TabIndex = 3;
            this.result_number_label.Text = "Total de registros";
            // 
            // search_text_box
            // 
            this.search_text_box.Location = new System.Drawing.Point(96, 22);
            this.search_text_box.Multiline = true;
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(118, 20);
            this.search_text_box.TabIndex = 1;
            this.search_text_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_box_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.AllowUserToDeleteRows = false;
            this.product_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Location = new System.Drawing.Point(17, 57);
            this.product_grid.Name = "product_grid";
            this.product_grid.ReadOnly = true;
            this.product_grid.Size = new System.Drawing.Size(505, 132);
            this.product_grid.TabIndex = 0;
            this.product_grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.product_grid_CellMouseUp);
            // 
            // PurchaseUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseUserControl";
            this.Size = new System.Drawing.Size(580, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Label result_number_label;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView product_grid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.TextBox amount_text_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_text_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox id_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number_text_box;
    }
}
