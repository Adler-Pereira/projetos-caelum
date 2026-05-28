namespace EditorDeTexto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.botaoCaixaAlta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(15, 14);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(290, 198);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(15, 316);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoReplace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textoReplace);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(105, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca e Alteração";
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(61, 19);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(132, 20);
            this.textoBusca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca";
            // 
            // botaoBusca
            // 
            this.botaoBusca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoBusca.Location = new System.Drawing.Point(8, 92);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 2;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(61, 46);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(132, 20);
            this.textoReplace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alteração";
            // 
            // botaoReplace
            // 
            this.botaoReplace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoReplace.Location = new System.Drawing.Point(118, 92);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 5;
            this.botaoReplace.Text = "Alterar";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // botaoCaixaAlta
            // 
            this.botaoCaixaAlta.Location = new System.Drawing.Point(15, 283);
            this.botaoCaixaAlta.Name = "botaoCaixaAlta";
            this.botaoCaixaAlta.Size = new System.Drawing.Size(75, 23);
            this.botaoCaixaAlta.TabIndex = 3;
            this.botaoCaixaAlta.Text = "Caixa Alta";
            this.botaoCaixaAlta.UseVisualStyleBackColor = true;
            this.botaoCaixaAlta.Click += new System.EventHandler(this.botaoCaixaAlta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(319, 351);
            this.Controls.Add(this.botaoCaixaAlta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Button botaoCaixaAlta;
    }
}

