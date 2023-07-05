namespace CRUDEF
{
    partial class FRMExcluirMunicipio
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDMunicipio = new System.Windows.Forms.TextBox();
            this.gridMunicipios = new System.Windows.Forms.DataGridView();
            this.colunaIDmunicipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCodIBGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(156, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Municipio";
            // 
            // txtIDMunicipio
            // 
            this.txtIDMunicipio.Location = new System.Drawing.Point(75, 8);
            this.txtIDMunicipio.Name = "txtIDMunicipio";
            this.txtIDMunicipio.Size = new System.Drawing.Size(75, 20);
            this.txtIDMunicipio.TabIndex = 3;
            // 
            // gridMunicipios
            // 
            this.gridMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIDmunicipio,
            this.colunaCodIBGE,
            this.ColunaDescricao});
            this.gridMunicipios.Location = new System.Drawing.Point(-3, 35);
            this.gridMunicipios.Name = "gridMunicipios";
            this.gridMunicipios.Size = new System.Drawing.Size(625, 336);
            this.gridMunicipios.TabIndex = 7;
            // 
            // colunaIDmunicipio
            // 
            this.colunaIDmunicipio.DataPropertyName = "idMunicipio";
            this.colunaIDmunicipio.HeaderText = "ID Municipio";
            this.colunaIDmunicipio.Name = "colunaIDmunicipio";
            this.colunaIDmunicipio.ReadOnly = true;
            // 
            // colunaCodIBGE
            // 
            this.colunaCodIBGE.DataPropertyName = "codIBGE";
            this.colunaCodIBGE.HeaderText = "CodiIBGE";
            this.colunaCodIBGE.Name = "colunaCodIBGE";
            this.colunaCodIBGE.ReadOnly = true;
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.DataPropertyName = "descricao";
            this.ColunaDescricao.HeaderText = "Descricao";
            this.ColunaDescricao.Name = "ColunaDescricao";
            this.ColunaDescricao.ReadOnly = true;
            // 
            // FRMExcluirMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 370);
            this.Controls.Add(this.gridMunicipios);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDMunicipio);
            this.Name = "FRMExcluirMunicipio";
            this.Text = "FRMExcluirMunicipio";
            this.Load += new System.EventHandler(this.FRMExcluirMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDMunicipio;
        private System.Windows.Forms.DataGridView gridMunicipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIDmunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaCodIBGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
    }
}