namespace PresentacionParcialFinal
{
    partial class PrincipalFrm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtNitAgente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.DgvTableRecaudo = new System.Windows.Forms.DataGridView();
            this.NitAgente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MesReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VigenciaReporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEstampilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDContratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreContratista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableRecaudo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNitAgente
            // 
            this.TxtNitAgente.Location = new System.Drawing.Point(95, 127);
            this.TxtNitAgente.Name = "TxtNitAgente";
            this.TxtNitAgente.Size = new System.Drawing.Size(146, 20);
            this.TxtNitAgente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nit del agente:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(95, 179);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar ";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importar recaudo a la base de datos";
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(621, 404);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(75, 23);
            this.BtnImportar.TabIndex = 4;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // DgvTableRecaudo
            // 
            this.DgvTableRecaudo.AllowUserToAddRows = false;
            this.DgvTableRecaudo.BackgroundColor = System.Drawing.Color.White;
            this.DgvTableRecaudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTableRecaudo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NitAgente,
            this.MesReporte,
            this.VigenciaReporte,
            this.TipoEstampilla,
            this.ValorImpuesto,
            this.IDContratista,
            this.NombreContratista});
            this.DgvTableRecaudo.Location = new System.Drawing.Point(85, 236);
            this.DgvTableRecaudo.Name = "DgvTableRecaudo";
            this.DgvTableRecaudo.Size = new System.Drawing.Size(611, 150);
            this.DgvTableRecaudo.TabIndex = 5;
            // 
            // NitAgente
            // 
            this.NitAgente.HeaderText = "NitAgente";
            this.NitAgente.Name = "NitAgente";
            // 
            // MesReporte
            // 
            this.MesReporte.HeaderText = "MesReporte";
            this.MesReporte.Name = "MesReporte";
            // 
            // VigenciaReporte
            // 
            this.VigenciaReporte.HeaderText = "VigenciaReporte";
            this.VigenciaReporte.Name = "VigenciaReporte";
            // 
            // TipoEstampilla
            // 
            this.TipoEstampilla.HeaderText = "TipoEstampilla";
            this.TipoEstampilla.Name = "TipoEstampilla";
            // 
            // ValorImpuesto
            // 
            this.ValorImpuesto.HeaderText = "ValorImpuesto";
            this.ValorImpuesto.Name = "ValorImpuesto";
            // 
            // IDContratista
            // 
            this.IDContratista.HeaderText = "IDContratista";
            this.IDContratista.Name = "IDContratista";
            // 
            // NombreContratista
            // 
            this.NombreContratista.HeaderText = "NombreContratista";
            this.NombreContratista.Name = "NombreContratista";
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvTableRecaudo);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNitAgente);
            this.Name = "PrincipalFrm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTableRecaudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNitAgente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.DataGridView DgvTableRecaudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NitAgente;
        private System.Windows.Forms.DataGridViewTextBoxColumn MesReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn VigenciaReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEstampilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDContratista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreContratista;
    }
}

