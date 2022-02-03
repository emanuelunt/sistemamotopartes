namespace MotoPartesErazo.Vistas
{
    partial class fImpuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fImpuesto));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.etTitulo = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.dataGrid_Impuesto = new System.Windows.Forms.DataGridView();
            this.id_impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olicuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe_bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.statusBarra = new System.Windows.Forms.StatusStrip();
            this.status_et_Estado = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelBarraTitulo.SuspendLayout();
            this.panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Impuesto)).BeginInit();
            this.statusBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBarraTitulo.Controls.Add(this.btn_close);
            this.panelBarraTitulo.Controls.Add(this.etTitulo);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(650, 30);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(618, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // etTitulo
            // 
            this.etTitulo.AutoSize = true;
            this.etTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTitulo.ForeColor = System.Drawing.Color.White;
            this.etTitulo.Location = new System.Drawing.Point(22, 9);
            this.etTitulo.Name = "etTitulo";
            this.etTitulo.Size = new System.Drawing.Size(106, 16);
            this.etTitulo.TabIndex = 0;
            this.etTitulo.Text = "Etiqueta de titulo";
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenido.Controls.Add(this.dataGrid_Impuesto);
            this.panelContenido.Controls.Add(this.btn_Eliminar);
            this.panelContenido.Controls.Add(this.btn_Editar);
            this.panelContenido.Controls.Add(this.btn_Nuevo);
            this.panelContenido.Controls.Add(this.statusBarra);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(0, 30);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(650, 349);
            this.panelContenido.TabIndex = 2;
            // 
            // dataGrid_Impuesto
            // 
            this.dataGrid_Impuesto.AllowUserToAddRows = false;
            this.dataGrid_Impuesto.AllowUserToDeleteRows = false;
            this.dataGrid_Impuesto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_Impuesto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid_Impuesto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid_Impuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Impuesto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid_Impuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Impuesto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Impuesto.ColumnHeadersHeight = 30;
            this.dataGrid_Impuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_Impuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_impuesto,
            this.nombre,
            this.olicuota,
            this.tipoiva,
            this.importe_neto,
            this.importe_bruto});
            this.dataGrid_Impuesto.EnableHeadersVisualStyles = false;
            this.dataGrid_Impuesto.Location = new System.Drawing.Point(12, 6);
            this.dataGrid_Impuesto.Name = "dataGrid_Impuesto";
            this.dataGrid_Impuesto.ReadOnly = true;
            this.dataGrid_Impuesto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Impuesto.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGrid_Impuesto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Impuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_Impuesto.Size = new System.Drawing.Size(620, 254);
            this.dataGrid_Impuesto.TabIndex = 7;
            // 
            // id_impuesto
            // 
            this.id_impuesto.HeaderText = "ID";
            this.id_impuesto.Name = "id_impuesto";
            this.id_impuesto.ReadOnly = true;
            this.id_impuesto.Width = 41;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Impuesto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 73;
            // 
            // olicuota
            // 
            this.olicuota.HeaderText = "Alícuota";
            this.olicuota.Name = "olicuota";
            this.olicuota.ReadOnly = true;
            this.olicuota.Width = 70;
            // 
            // tipoiva
            // 
            this.tipoiva.HeaderText = "Tipo Iva";
            this.tipoiva.Name = "tipoiva";
            this.tipoiva.ReadOnly = true;
            this.tipoiva.Width = 64;
            // 
            // importe_neto
            // 
            this.importe_neto.HeaderText = "Importe Neto";
            this.importe_neto.Name = "importe_neto";
            this.importe_neto.ReadOnly = true;
            this.importe_neto.Width = 84;
            // 
            // importe_bruto
            // 
            this.importe_bruto.HeaderText = "Importe Bruto";
            this.importe_bruto.Name = "importe_bruto";
            this.importe_bruto.ReadOnly = true;
            this.importe_bruto.Width = 85;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Eliminar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(477, 285);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(155, 34);
            this.btn_Eliminar.TabIndex = 6;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Editar.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Image")));
            this.btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Location = new System.Drawing.Point(247, 285);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(155, 34);
            this.btn_Editar.TabIndex = 5;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Nuevo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Nuevo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Nuevo.Location = new System.Drawing.Point(25, 285);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(155, 34);
            this.btn_Nuevo.TabIndex = 4;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // statusBarra
            // 
            this.statusBarra.BackColor = System.Drawing.Color.CornflowerBlue;
            this.statusBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_et_Estado});
            this.statusBarra.Location = new System.Drawing.Point(0, 327);
            this.statusBarra.Name = "statusBarra";
            this.statusBarra.Size = new System.Drawing.Size(650, 22);
            this.statusBarra.TabIndex = 0;
            this.statusBarra.Text = "statusStrip1";
            // 
            // status_et_Estado
            // 
            this.status_et_Estado.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_et_Estado.ForeColor = System.Drawing.Color.White;
            this.status_et_Estado.Name = "status_et_Estado";
            this.status_et_Estado.Size = new System.Drawing.Size(52, 17);
            this.status_et_Estado.Text = "Estado";
            // 
            // fImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 379);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fImpuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fImpuesto";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Impuesto)).EndInit();
            this.statusBarra.ResumeLayout(false);
            this.statusBarra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.StatusStrip statusBarra;
        private System.Windows.Forms.ToolStripStatusLabel status_et_Estado;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dataGrid_Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn olicuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe_bruto;
    }
}