namespace TKG
{
    partial class PurchaseRecords
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
            this.purchase_grid = new System.Windows.Forms.DataGridView();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_export2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.result_number_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchase_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchase_grid
            // 
            this.purchase_grid.AllowUserToAddRows = false;
            this.purchase_grid.AllowUserToDeleteRows = false;
            this.purchase_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.purchase_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchase_grid.Location = new System.Drawing.Point(34, 120);
            this.purchase_grid.MultiSelect = false;
            this.purchase_grid.Name = "purchase_grid";
            this.purchase_grid.ReadOnly = true;
            this.purchase_grid.Size = new System.Drawing.Size(498, 252);
            this.purchase_grid.TabIndex = 0;
            this.purchase_grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.purchase_grid_CellMouseUp);
            // 
            // search_text_box
            // 
            this.search_text_box.Location = new System.Drawing.Point(97, 93);
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(100, 21);
            this.search_text_box.TabIndex = 1;
            this.search_text_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_box_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // btn_export2
            // 
            this.btn_export2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_export2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export2.Image = global::TKG.Properties.Resources.excel;
            this.btn_export2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export2.Location = new System.Drawing.Point(432, 73);
            this.btn_export2.Name = "btn_export2";
            this.btn_export2.Size = new System.Drawing.Size(100, 41);
            this.btn_export2.TabIndex = 3;
            this.btn_export2.Text = "     Exportar";
            this.btn_export2.UseVisualStyleBackColor = true;
            this.btn_export2.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.result_number_label);
            this.groupBox1.Controls.Add(this.purchase_grid);
            this.groupBox1.Controls.Add(this.btn_export2);
            this.groupBox1.Controls.Add(this.search_text_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 404);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras de productos";
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(489, 0);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(53, 21);
            this.id_text_box.TabIndex = 5;
            this.id_text_box.Visible = false;
            // 
            // result_number_label
            // 
            this.result_number_label.AutoSize = true;
            this.result_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number_label.Location = new System.Drawing.Point(31, 375);
            this.result_number_label.Name = "result_number_label";
            this.result_number_label.Size = new System.Drawing.Size(88, 13);
            this.result_number_label.TabIndex = 4;
            this.result_number_label.Text = "Total de registros";
            // 
            // PurchaseRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseRecords";
            this.Size = new System.Drawing.Size(580, 420);
            ((System.ComponentModel.ISupportInitialize)(this.purchase_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView purchase_grid;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_export2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label result_number_label;
        private System.Windows.Forms.TextBox id_text_box;
    }
}
