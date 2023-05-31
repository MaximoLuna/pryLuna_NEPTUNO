namespace pryLuna_NEPTUNO
{
    partial class frmTablas
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
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.lblBaseDatos = new System.Windows.Forms.Label();
            this.lblTabla = new System.Windows.Forms.Label();
            this.dgvTablas = new System.Windows.Forms.DataGridView();
            this.cmbTablas = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBaseDeDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(95, 15);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.ReadOnly = true;
            this.txtBaseDatos.Size = new System.Drawing.Size(100, 20);
            this.txtBaseDatos.TabIndex = 10;
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.AutoSize = true;
            this.lblBaseDatos.Enabled = false;
            this.lblBaseDatos.Location = new System.Drawing.Point(9, 18);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(80, 13);
            this.lblBaseDatos.TabIndex = 9;
            this.lblBaseDatos.Text = "Base de Datos:";
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Enabled = false;
            this.lblTabla.Location = new System.Drawing.Point(209, 17);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(37, 13);
            this.lblTabla.TabIndex = 8;
            this.lblTabla.Text = "Tabla:";
            // 
            // dgvTablas
            // 
            this.dgvTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablas.Location = new System.Drawing.Point(12, 64);
            this.dgvTablas.Name = "dgvTablas";
            this.dgvTablas.Size = new System.Drawing.Size(518, 306);
            this.dgvTablas.TabIndex = 7;
            // 
            // cmbTablas
            // 
            this.cmbTablas.Enabled = false;
            this.cmbTablas.FormattingEnabled = true;
            this.cmbTablas.Location = new System.Drawing.Point(252, 14);
            this.cmbTablas.Name = "cmbTablas";
            this.cmbTablas.Size = new System.Drawing.Size(121, 21);
            this.cmbTablas.TabIndex = 6;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 36);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBaseDeDatos
            // 
            this.btnBaseDeDatos.Location = new System.Drawing.Point(557, 64);
            this.btnBaseDeDatos.Name = "btnBaseDeDatos";
            this.btnBaseDeDatos.Size = new System.Drawing.Size(96, 36);
            this.btnBaseDeDatos.TabIndex = 14;
            this.btnBaseDeDatos.Text = "Seleccionar BD";
            this.btnBaseDeDatos.UseVisualStyleBackColor = true;
            this.btnBaseDeDatos.Click += new System.EventHandler(this.btnBaseDeDatos_Click);
            // 
            // frmTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 429);
            this.Controls.Add(this.btnBaseDeDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtBaseDatos);
            this.Controls.Add(this.lblBaseDatos);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.dgvTablas);
            this.Controls.Add(this.cmbTablas);
            this.Name = "frmTablas";
            this.Text = "NEPTUNO - Tablas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBaseDatos;
        private System.Windows.Forms.Label lblBaseDatos;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.DataGridView dgvTablas;
        private System.Windows.Forms.ComboBox cmbTablas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBaseDeDatos;
    }
}