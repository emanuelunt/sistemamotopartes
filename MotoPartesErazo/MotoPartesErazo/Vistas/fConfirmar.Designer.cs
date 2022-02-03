namespace MotoPartesErazo.Vistas
{
    partial class fConfirmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConfirmar));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.etTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_No = new System.Windows.Forms.Button();
            this.btn_Si = new System.Windows.Forms.Button();
            this.pictureBoxIcono = new System.Windows.Forms.PictureBox();
            this.etMensaje = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).BeginInit();
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
            this.panelBarraTitulo.Size = new System.Drawing.Size(547, 30);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(515, 0);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.btn_No);
            this.panel1.Controls.Add(this.btn_Si);
            this.panel1.Controls.Add(this.pictureBoxIcono);
            this.panel1.Controls.Add(this.etMensaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 149);
            this.panel1.TabIndex = 3;
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_No.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_No.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_No.ForeColor = System.Drawing.Color.White;
            this.btn_No.Location = new System.Drawing.Point(338, 92);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(96, 34);
            this.btn_No.TabIndex = 3;
            this.btn_No.Text = "NO";
            this.btn_No.UseVisualStyleBackColor = false;
            // 
            // btn_Si
            // 
            this.btn_Si.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Si.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btn_Si.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Si.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Si.ForeColor = System.Drawing.Color.White;
            this.btn_Si.Location = new System.Drawing.Point(131, 92);
            this.btn_Si.Name = "btn_Si";
            this.btn_Si.Size = new System.Drawing.Size(96, 34);
            this.btn_Si.TabIndex = 2;
            this.btn_Si.Text = "SI";
            this.btn_Si.UseVisualStyleBackColor = false;
            this.btn_Si.Click += new System.EventHandler(this.btn_Si_Click);
            // 
            // pictureBoxIcono
            // 
            this.pictureBoxIcono.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcono.Image")));
            this.pictureBoxIcono.InitialImage = null;
            this.pictureBoxIcono.Location = new System.Drawing.Point(25, 15);
            this.pictureBoxIcono.Name = "pictureBoxIcono";
            this.pictureBoxIcono.Size = new System.Drawing.Size(63, 58);
            this.pictureBoxIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcono.TabIndex = 1;
            this.pictureBoxIcono.TabStop = false;
            this.pictureBoxIcono.Click += new System.EventHandler(this.pictureBoxIcono_Click);
            // 
            // etMensaje
            // 
            this.etMensaje.AutoSize = true;
            this.etMensaje.BackColor = System.Drawing.Color.Transparent;
            this.etMensaje.Cursor = System.Windows.Forms.Cursors.Default;
            this.etMensaje.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.etMensaje.Location = new System.Drawing.Point(127, 30);
            this.etMensaje.Name = "etMensaje";
            this.etMensaje.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.etMensaje.Size = new System.Drawing.Size(307, 43);
            this.etMensaje.TabIndex = 0;
            this.etMensaje.Text = "¿Confirma eliminar el registro?";
            this.etMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fConfirmar
            // 
            this.AcceptButton = this.btn_Si;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_No;
            this.ClientSize = new System.Drawing.Size(547, 179);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "fConfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fConfirmar";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxIcono;
        private System.Windows.Forms.Label etMensaje;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Button btn_Si;
    }
}