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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnTrazerPrimeiro = new System.Windows.Forms.Button();
            this.btnTop5 = new System.Windows.Forms.Button();
            this.btnTop5Utimos = new System.Windows.Forms.Button();
            this.btnUtimo = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarMuni = new System.Windows.Forms.Button();
            this.ColunaSigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEstados
            // 
            this.gridEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaSigla,
            this.ColunaDescricao});
            this.gridEstados.Location = new System.Drawing.Point(0, 165);
            this.gridEstados.Name = "gridEstados";
            this.gridEstados.Size = new System.Drawing.Size(489, 232);
            this.gridEstados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estados Cadastrados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(415, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Todos";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnTrazerPrimeiro
            // 
            this.btnTrazerPrimeiro.Location = new System.Drawing.Point(1, 2);
            this.btnTrazerPrimeiro.Name = "btnTrazerPrimeiro";
            this.btnTrazerPrimeiro.Size = new System.Drawing.Size(87, 39);
            this.btnTrazerPrimeiro.TabIndex = 3;
            this.btnTrazerPrimeiro.Text = "Trazer Primeiro Registro";
            this.btnTrazerPrimeiro.UseVisualStyleBackColor = true;
            this.btnTrazerPrimeiro.Click += new System.EventHandler(this.btnTrazerPrimeiro_Click);
            // 
            // btnTop5
            // 
            this.btnTop5.Location = new System.Drawing.Point(177, 2);
            this.btnTop5.Name = "btnTop5";
            this.btnTop5.Size = new System.Drawing.Size(87, 39);
            this.btnTop5.TabIndex = 4;
            this.btnTop5.Text = "TOP 5 Primeiros";
            this.btnTop5.UseVisualStyleBackColor = true;
            this.btnTop5.Click += new System.EventHandler(this.btnTop5_Click);
            // 
            // btnTop5Utimos
            // 
            this.btnTop5Utimos.Location = new System.Drawing.Point(265, 2);
            this.btnTop5Utimos.Name = "btnTop5Utimos";
            this.btnTop5Utimos.Size = new System.Drawing.Size(87, 39);
            this.btnTop5Utimos.TabIndex = 5;
            this.btnTop5Utimos.Text = "TOP 5 Utimos";
            this.btnTop5Utimos.UseVisualStyleBackColor = true;
            this.btnTop5Utimos.Click += new System.EventHandler(this.btnTop5Utimos_Click);
            // 
            // btnUtimo
            // 
            this.btnUtimo.Location = new System.Drawing.Point(89, 2);
            this.btnUtimo.Name = "btnUtimo";
            this.btnUtimo.Size = new System.Drawing.Size(87, 39);
            this.btnUtimo.TabIndex = 6;
            this.btnUtimo.Text = "Trazer Utimo Registro";
            this.btnUtimo.UseVisualStyleBackColor = true;
            this.btnUtimo.Click += new System.EventHandler(this.btnUtimo_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(56, 67);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(48, 23);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(1, 69);
            this.txtFiltro.MaxLength = 2;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(49, 20);
            this.txtFiltro.TabIndex = 8;
            this.txtFiltro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtrar";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 3);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnCadastrarMuni
            // 
            this.btnCadastrarMuni.Location = new System.Drawing.Point(415, 50);
            this.btnCadastrarMuni.Name = "btnCadastrarMuni";
            this.btnCadastrarMuni.Size = new System.Drawing.Size(76, 39);
            this.btnCadastrarMuni.TabIndex = 11;
            this.btnCadastrarMuni.Text = "Cadastrar Munícipio";
            this.btnCadastrarMuni.UseVisualStyleBackColor = true;
            this.btnCadastrarMuni.Click += new System.EventHandler(this.btnCadastrarMuni_Click);
            // 
            // ColunaSigla
            // 
            this.ColunaSigla.DataPropertyName = "Sigla";
            this.ColunaSigla.HeaderText = "Sigla";
            this.ColunaSigla.Name = "ColunaSigla";
            this.ColunaSigla.ReadOnly = true;
            // 
            // ColunaDescricao
            // 
            this.ColunaDescricao.DataPropertyName = "Descricao";
            this.ColunaDescricao.HeaderText = "Descrição";
            this.ColunaDescricao.Name = "ColunaDescricao";
            this.ColunaDescricao.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 399);
            this.Controls.Add(this.btnCadastrarMuni);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.btnUtimo);
            this.Controls.Add(this.btnTop5Utimos);
            this.Controls.Add(this.btnTop5);
            this.Controls.Add(this.btnTrazerPrimeiro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridEstados);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEstados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnTrazerPrimeiro;
        private System.Windows.Forms.Button btnTop5;
        private System.Windows.Forms.Button btnTop5Utimos;
        private System.Windows.Forms.Button btnUtimo;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarMuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaSigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaDescricao;
    }
}

