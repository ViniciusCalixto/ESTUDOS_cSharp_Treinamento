namespace CRUDEF
{
    partial class FRMMunicipio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodIBGE = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEstados = new System.Windows.Forms.ComboBox();
            this.gridMunicipios = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.ColunaCODIBGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDescricaoEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo IBGE";
            // 
            // txtCodIBGE
            // 
            this.txtCodIBGE.Location = new System.Drawing.Point(68, 6);
            this.txtCodIBGE.Name = "txtCodIBGE";
            this.txtCodIBGE.Size = new System.Drawing.Size(80, 20);
            this.txtCodIBGE.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(68, 28);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(377, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboEstados
            // 
            this.comboEstados.FormattingEnabled = true;
            this.comboEstados.Location = new System.Drawing.Point(68, 50);
            this.comboEstados.Name = "comboEstados";
            this.comboEstados.Size = new System.Drawing.Size(80, 21);
            this.comboEstados.TabIndex = 5;
            this.comboEstados.SelectedIndexChanged += new System.EventHandler(this.comboEstados_SelectedIndexChanged);
            // 
            // gridMunicipios
            // 
            this.gridMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaCODIBGE,
            this.colunaDescricao,
            this.colunaDescricaoEstado});
            this.gridMunicipios.Location = new System.Drawing.Point(0, 79);
            this.gridMunicipios.Name = "gridMunicipios";
            this.gridMunicipios.Size = new System.Drawing.Size(445, 207);
            this.gridMunicipios.TabIndex = 6;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(154, 50);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 7;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(231, 50);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(308, 50);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // ColunaCODIBGE
            // 
            this.ColunaCODIBGE.DataPropertyName = "CodIBGE";
            this.ColunaCODIBGE.HeaderText = "Codigo IBGE";
            this.ColunaCODIBGE.Name = "ColunaCODIBGE";
            this.ColunaCODIBGE.ReadOnly = true;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.DataPropertyName = "Descricao";
            this.colunaDescricao.HeaderText = "Descrição";
            this.colunaDescricao.Name = "colunaDescricao";
            this.colunaDescricao.ReadOnly = true;
            // 
            // colunaDescricaoEstado
            // 
            this.colunaDescricaoEstado.DataPropertyName = "Estado.Descricao";
            this.colunaDescricaoEstado.HeaderText = "Estado";
            this.colunaDescricaoEstado.Name = "colunaDescricaoEstado";
            this.colunaDescricaoEstado.ReadOnly = true;
            // 
            // FRMMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 287);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gridMunicipios);
            this.Controls.Add(this.comboEstados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodIBGE);
            this.Controls.Add(this.label1);
            this.Name = "FRMMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMMunicipio";
            this.Load += new System.EventHandler(this.FRMMunicipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMunicipios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodIBGE;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEstados;
        private System.Windows.Forms.DataGridView gridMunicipios;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaCODIBGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDescricaoEstado;
    }
}