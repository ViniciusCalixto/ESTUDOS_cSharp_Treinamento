namespace CRUDEF
{
    partial class Form1
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
            this.gridEstados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTrazerOPrimeiro = new System.Windows.Forms.Button();
            this.btnTrazerOsCincoPrimeiros = new System.Windows.Forms.Button();
            this.btnTrazerCincoUltimos = new System.Windows.Forms.Button();
            this.btnTrazerUltimo = new System.Windows.Forms.Button();
            this.btnTrazerFiltrado = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnIncluirMunicipio = new System.Windows.Forms.Button();
            this.colunaSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstados
            // 
            this.gridEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaSigla,
            this.colunaDescricao});
            this.gridEstados.Location = new System.Drawing.Point(22, 145);
            this.gridEstados.Name = "gridEstados";
            this.gridEstados.Size = new System.Drawing.Size(455, 253);
            this.gridEstados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estados cadastrados";
            // 
            // btnTrazerOPrimeiro
            // 
            this.btnTrazerOPrimeiro.Location = new System.Drawing.Point(3, 3);
            this.btnTrazerOPrimeiro.Name = "btnTrazerOPrimeiro";
            this.btnTrazerOPrimeiro.Size = new System.Drawing.Size(106, 34);
            this.btnTrazerOPrimeiro.TabIndex = 2;
            this.btnTrazerOPrimeiro.Text = "Trazer o primeiro registro";
            this.btnTrazerOPrimeiro.UseVisualStyleBackColor = true;
            this.btnTrazerOPrimeiro.Click += new System.EventHandler(this.btnTrazerOPrimeiro_Click);
            // 
            // btnTrazerOsCincoPrimeiros
            // 
            this.btnTrazerOsCincoPrimeiros.Location = new System.Drawing.Point(115, 3);
            this.btnTrazerOsCincoPrimeiros.Name = "btnTrazerOsCincoPrimeiros";
            this.btnTrazerOsCincoPrimeiros.Size = new System.Drawing.Size(106, 34);
            this.btnTrazerOsCincoPrimeiros.TabIndex = 3;
            this.btnTrazerOsCincoPrimeiros.Text = "Trazer os 5 primeiros registros";
            this.btnTrazerOsCincoPrimeiros.UseVisualStyleBackColor = true;
            this.btnTrazerOsCincoPrimeiros.Click += new System.EventHandler(this.btnTrazerOsCincoPrimeiros_Click);
            // 
            // btnTrazerCincoUltimos
            // 
            this.btnTrazerCincoUltimos.Location = new System.Drawing.Point(227, 3);
            this.btnTrazerCincoUltimos.Name = "btnTrazerCincoUltimos";
            this.btnTrazerCincoUltimos.Size = new System.Drawing.Size(106, 34);
            this.btnTrazerCincoUltimos.TabIndex = 4;
            this.btnTrazerCincoUltimos.Text = "Trazer os 5 últimos registros";
            this.btnTrazerCincoUltimos.UseVisualStyleBackColor = true;
            this.btnTrazerCincoUltimos.Click += new System.EventHandler(this.btnTrazerCincoUltimos_Click);
            // 
            // btnTrazerUltimo
            // 
            this.btnTrazerUltimo.Location = new System.Drawing.Point(339, 3);
            this.btnTrazerUltimo.Name = "btnTrazerUltimo";
            this.btnTrazerUltimo.Size = new System.Drawing.Size(106, 34);
            this.btnTrazerUltimo.TabIndex = 5;
            this.btnTrazerUltimo.Text = "Trazer o último registro";
            this.btnTrazerUltimo.UseVisualStyleBackColor = true;
            this.btnTrazerUltimo.Click += new System.EventHandler(this.btnTrazerUltimo_Click);
            // 
            // btnTrazerFiltrado
            // 
            this.btnTrazerFiltrado.Location = new System.Drawing.Point(3, 58);
            this.btnTrazerFiltrado.Name = "btnTrazerFiltrado";
            this.btnTrazerFiltrado.Size = new System.Drawing.Size(106, 34);
            this.btnTrazerFiltrado.TabIndex = 6;
            this.btnTrazerFiltrado.Text = "Trazer filtrado";
            this.btnTrazerFiltrado.UseVisualStyleBackColor = true;
            this.btnTrazerFiltrado.Click += new System.EventHandler(this.btnTrazerFiltrado_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(115, 66);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 7;
            // 
            // btnIncluirMunicipio
            // 
            this.btnIncluirMunicipio.Location = new System.Drawing.Point(227, 58);
            this.btnIncluirMunicipio.Name = "btnIncluirMunicipio";
            this.btnIncluirMunicipio.Size = new System.Drawing.Size(106, 34);
            this.btnIncluirMunicipio.TabIndex = 8;
            this.btnIncluirMunicipio.Text = "Cadastrar Município";
            this.btnIncluirMunicipio.UseVisualStyleBackColor = true;
            this.btnIncluirMunicipio.Click += new System.EventHandler(this.btnIncluirMunicipio_Click);
            // 
            // colunaSigla
            // 
            this.colunaSigla.DataPropertyName = "Sigla";
            this.colunaSigla.HeaderText = "Sigla";
            this.colunaSigla.Name = "colunaSigla";
            this.colunaSigla.ReadOnly = true;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.DataPropertyName = "Descricao";
            this.colunaDescricao.HeaderText = "Descrição";
            this.colunaDescricao.Name = "colunaDescricao";
            this.colunaDescricao.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 405);
            this.Controls.Add(this.btnIncluirMunicipio);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnTrazerFiltrado);
            this.Controls.Add(this.btnTrazerUltimo);
            this.Controls.Add(this.btnTrazerCincoUltimos);
            this.Controls.Add(this.btnTrazerOsCincoPrimeiros);
            this.Controls.Add(this.btnTrazerOPrimeiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEstados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTrazerOPrimeiro;
        private System.Windows.Forms.Button btnTrazerOsCincoPrimeiros;
        private System.Windows.Forms.Button btnTrazerCincoUltimos;
        private System.Windows.Forms.Button btnTrazerUltimo;
        private System.Windows.Forms.Button btnTrazerFiltrado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnIncluirMunicipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaSigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDescricao;
    }
}

