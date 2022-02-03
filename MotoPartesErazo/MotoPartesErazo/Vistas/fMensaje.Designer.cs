namespace MotoPartesErazo.Vistas
{
    partial class fMensajes
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
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.etTitulo = new System.Windows.Forms.Label();
            this.etMensaje = new System.Windows.Forms.Label();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Si = new System.Windows.Forms.Button();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(503, 30);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraTitulo_Paint);
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(471, 0);
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
            // etMensaje
            // 
            this.etMensaje.AutoSize = true;
            this.etMensaje.BackColor = System.Drawing.Color.Transparent;
            this.etMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.etMensaje.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.etMensaje.Location = new System.Drawing.Point(85, 23);
            this.etMensaje.Name = "etMensaje";
            this.etMensaje.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.etMensaje.Size = new System.Drawing.Size(159, 37);
            this.etMensaje.TabIndex = 0;
            this.etMensaje.Text = "Etiqueta de Mensajes";
            this.etMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.InitialImage = null;
            this.pictureBoxIcono.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(67, 67);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcono.TabIndex = 1;
            this.pictureBoxIcono.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_Si);
            this.panel1.Controls.Add(this.pictureBoxIcono);
            this.panel1.Controls.Add(this.etMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 129);
            this.panel1.TabIndex = 2;
            // 
            // btn_Si
            // 
            this.btn_Si.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Si.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Si.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Si.ForeColor = System.Drawing.Color.White;
            this.btn_Si.Location = new System.Drawing.Point(194, 83);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(109, 34);
            this.btn_Si.TabIndex = 3;
            this.btn_Si.Text = "Aceptar";
            this.btn_Si.UseVisualStyleBackColor = false;
            // 
            // fMensajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 159);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fMensajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iconos";
            this.Shown += new System.EventHandler(this.fMensajes_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMensajes_KeyDown);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.Label etMensaje;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Si;
    }
}