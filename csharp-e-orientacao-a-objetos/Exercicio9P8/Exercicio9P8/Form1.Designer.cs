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
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.btTotalConta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCompValor)).BeginInit();
            this.SuspendLayout();
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(124, 354);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.ReadOnly = true;
            this.textoTitular.Size = new System.Drawing.Size(217, 20);
            this.textoTitular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saldo";
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(124, 380);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.ReadOnly = true;
            this.textoSaldo.Size = new System.Drawing.Size(217, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(124, 406);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(217, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(124, 432);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(217, 20);
            this.textoValor.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(34, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoDepositar.Location = new System.Drawing.Point(170, 164);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 4;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botaoSacar.Location = new System.Drawing.Point(251, 164);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 5;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.botaoSacar_Click);
            // 
            // btTotalConta
            // 
            this.btTotalConta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTotalConta.Location = new System.Drawing.Point(22, 164);
            this.btTotalConta.Name = "btTotalConta";
            this.btTotalConta.Size = new System.Drawing.Size(103, 23);
            this.btTotalConta.TabIndex = 6;
            this.btTotalConta.Text = "Totalizar Contas";
            this.btTotalConta.UseVisualStyleBackColor = true;
            this.btTotalConta.Click += new System.EventHandler(this.btTotalConta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTotalConta);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.botaoSacar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(15, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(15, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de Conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(108, 39);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(217, 21);
            this.comboContas.TabIndex = 9;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha a conta";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.numCompValor);
            this.groupBox3.Controls.Add(this.btTransferencia);
            this.groupBox3.Controls.Add(this.comboDestinoTransferencia);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(15, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 162);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transferência";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(71, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Valor";
            // 
            // numCompValor
            // 
            this.numCompValor.Location = new System.Drawing.Point(108, 66);
            this.numCompValor.Name = "numCompValor";
            this.numCompValor.Size = new System.Drawing.Size(120, 20);
            this.numCompValor.TabIndex = 11;
            // 
            // btTransferencia
            // 
            this.btTransferencia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTransferencia.Location = new System.Drawing.Point(140, 108);
            this.btTransferencia.Name = "btTransferencia";
            this.btTransferencia.Size = new System.Drawing.Size(75, 23);
            this.btTransferencia.TabIndex = 10;
            this.btTransferencia.Text = "Transferir";
            this.btTransferencia.UseVisualStyleBackColor = true;
            this.btTransferencia.Click += new System.EventHandler(this.btTransferencia_Click);
            // 
            // comboDestinoTransferencia
            // 
            this.comboDestinoTransferencia.FormattingEnabled = true;
            this.comboDestinoTransferencia.Location = new System.Drawing.Point(108, 39);
            this.comboDestinoTransferencia.Name = "comboDestinoTransferencia";
            this.comboDestinoTransferencia.Size = new System.Drawing.Size(217, 21);
            this.comboDestinoTransferencia.TabIndex = 9;
            this.comboDestinoTransferencia.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Escolha a conta";
            // 
            // btNovaConta
            // 
            this.btNovaConta.Location = new System.Drawing.Point(15, 530);
            this.btNovaConta.Name = "btNovaConta";
            this.btNovaConta.Size = new System.Drawing.Size(75, 23);
            this.btNovaConta.TabIndex = 9;
            this.btNovaConta.Text = "Nova Conta";
            this.btNovaConta.UseVisualStyleBackColor = true;
            this.btNovaConta.Click += new System.EventHandler(this.btNovaConta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(382, 580);
            this.Controls.Add(this.btNovaConta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textoValor;
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
    }
}

