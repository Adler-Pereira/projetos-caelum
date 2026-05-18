namespace Exercicio9P8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.btTotalConta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textoValor = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numCompValor = new System.Windows.Forms.NumericUpDown();
            this.btTransferencia = new System.Windows.Forms.Button();
            this.comboDestinoTransferencia = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btNovaConta = new System.Windows.Forms.Button();
            this.botaoImpostos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoValor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompValor)).BeginInit();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            resources.ApplyResources(this.textoTitular, "textoTitular");
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // textoSaldo
            // 
            resources.ApplyResources(this.textoSaldo, "textoSaldo");
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.ReadOnly = true;
            // 
            // textoNumero
            // 
            resources.ApplyResources(this.textoNumero, "textoNumero");
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Name = "label4";
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.botaoDepositar, "botaoDepositar");
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.botaoSacar, "botaoSacar");
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // btTotalConta
            // 
            this.btTotalConta.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btTotalConta, "btTotalConta");
            this.btTotalConta.Name = "btTotalConta";
            this.btTotalConta.UseVisualStyleBackColor = true;
            this.btTotalConta.Click += new System.EventHandler(this.btTotalConta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.botaoSacar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textoValor
            // 
            this.textoValor.DecimalPlaces = 2;
            resources.ApplyResources(this.textoValor, "textoValor");
            this.textoValor.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.textoValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.textoValor.Name = "textoValor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            resources.ApplyResources(this.comboContas, "comboContas");
            this.comboContas.Name = "comboContas";
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numCompValor);
            this.groupBox3.Controls.Add(this.btTransferencia);
            this.groupBox3.Controls.Add(this.comboDestinoTransferencia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Name = "label7";
            // 
            // numCompValor
            // 
            this.numCompValor.DecimalPlaces = 2;
            resources.ApplyResources(this.numCompValor, "numCompValor");
            this.numCompValor.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numCompValor.Name = "numCompValor";
            // 
            // btTransferencia
            // 
            this.btTransferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btTransferencia, "btTransferencia");
            this.btTransferencia.Name = "btTransferencia";
            this.btTransferencia.UseVisualStyleBackColor = true;
            this.btTransferencia.Click += new System.EventHandler(this.btTransferencia_Click);
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            resources.ApplyResources(this.comboDestinoTransferencia, "comboDestinoTransferencia");
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btNovaConta
            // 
            this.btNovaConta.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.btNovaConta, "btNovaConta");
            this.btNovaConta.Name = "btNovaConta";
            this.btNovaConta.UseVisualStyleBackColor = true;
            this.btNovaConta.Click += new System.EventHandler(this.btNovaConta_Click);
            // 
            // botaoImpostos
            // 
            resources.ApplyResources(this.botaoImpostos, "botaoImpostos");
            this.botaoImpostos.Name = "botaoImpostos";
            this.botaoImpostos.UseVisualStyleBackColor = true;
            this.botaoImpostos.Click += new System.EventHandler(this.botaoImpostos_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.botaoImpostos);
            this.Controls.Add(this.btNovaConta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btTotalConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoValor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.Button btTotalConta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTransferencia;
        private System.Windows.Forms.ComboBox comboDestinoTransferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numCompValor;
        private System.Windows.Forms.Button btNovaConta;
        private System.Windows.Forms.NumericUpDown textoValor;
        private System.Windows.Forms.Button botaoImpostos;
    }
}

