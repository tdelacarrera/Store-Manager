namespace TKG
{
    partial class AuditRecords
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
            this.result_number_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.audit_grid = new System.Windows.Forms.DataGridView();
            this.id_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_text_box = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audit_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // result_number_label
            // 
            this.result_number_label.AutoSize = true;
            this.result_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_number_label.Location = new System.Drawing.Point(26, 351);
            this.result_number_label.Name = "result_number_label";
            this.result_number_label.Size = new System.Drawing.Size(88, 13);
            this.result_number_label.TabIndex = 1;
            this.result_number_label.Text = "Total de registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.audit_grid);
            this.groupBox1.Controls.Add(this.id_text_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.search_text_box);
            this.groupBox1.Controls.Add(this.btn_export);
            this.groupBox1.Controls.Add(this.result_number_label);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auditor";
            // 
            // audit_grid
            // 
            this.audit_grid.AllowUserToAddRows = false;
            this.audit_grid.AllowUserToDeleteRows = false;
            this.audit_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.audit_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.audit_grid.Location = new System.Drawing.Point(29, 76);
            this.audit_grid.MultiSelect = false;
            this.audit_grid.Name = "audit_grid";
            this.audit_grid.ReadOnly = true;
            this.audit_grid.Size = new System.Drawing.Size(495, 262);
            this.audit_grid.TabIndex = 6;
            // 
            // id_text_box
            // 
            this.id_text_box.Location = new System.Drawing.Point(447, -3);
            this.id_text_box.Name = "id_text_box";
            this.id_text_box.Size = new System.Drawing.Size(49, 21);
            this.id_text_box.TabIndex = 5;
            this.id_text_box.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // search_text_box
            // 
            this.search_text_box.Location = new System.Drawing.Point(85, 41);
            this.search_text_box.Name = "search_text_box";
            this.search_text_box.Size = new System.Drawing.Size(100, 21);
            this.search_text_box.TabIndex = 3;
            this.search_text_box.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_text_box_KeyUp);
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.Location = new System.Drawing.Point(409, 32);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(115, 38);
            this.btn_export.TabIndex = 2;
            this.btn_export.Text = "         Exportar";
            this.btn_export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // AuditRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Name = "AuditRecords";
            this.Size = new System.Drawing.Size(580, 420);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audit_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label result_number_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_text_box;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.TextBox id_text_box;
        private System.Windows.Forms.DataGridView audit_grid;
    }
}
