namespace Exercicios5P4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSoma1A1000 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMult3De1A100 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSomaSemMult3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDivisores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFatoriais = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnForsEncadeados = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(201, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXERCÍCIOS 5.4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(95, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1) 2^5";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(79, 87);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSoma1A1000
            // 
            this.btnSoma1A1000.Location = new System.Drawing.Point(349, 87);
            this.btnSoma1A1000.Name = "btnSoma1A1000";
            this.btnSoma1A1000.Size = new System.Drawing.Size(75, 23);
            this.btnSoma1A1000.TabIndex = 4;
            this.btnSoma1A1000.Text = "ver soma";
            this.btnSoma1A1000.UseVisualStyleBackColor = true;
            this.btnSoma1A1000.Click += new System.EventHandler(this.btnSoma1A1000_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(299, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2) Soma dos números de 1 até 1000";
            // 
            // btnMult3De1A100
            // 
            this.btnMult3De1A100.Location = new System.Drawing.Point(79, 172);
            this.btnMult3De1A100.Name = "btnMult3De1A100";
            this.btnMult3De1A100.Size = new System.Drawing.Size(75, 23);
            this.btnMult3De1A100.TabIndex = 6;
            this.btnMult3De1A100.Text = "ver multiplos";
            this.btnMult3De1A100.UseVisualStyleBackColor = true;
            this.btnMult3De1A100.Click += new System.EventHandler(this.btnMult3De1A100_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(55, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3) Múltiplos de 3 até 100";
            // 
            // btnSomaSemMult3
            // 
            this.btnSomaSemMult3.Location = new System.Drawing.Point(349, 172);
            this.btnSomaSemMult3.Name = "btnSomaSemMult3";
            this.btnSomaSemMult3.Size = new System.Drawing.Size(75, 23);
            this.btnSomaSemMult3.TabIndex = 10;
            this.btnSomaSemMult3.Text = "ver soma";
            this.btnSomaSemMult3.UseVisualStyleBackColor = true;
            this.btnSomaSemMult3.Click += new System.EventHandler(this.btnSomaSemMult3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(290, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "4) Soma de 1 a 100 ( pulando mult. de 3)";
            // 
            // btnDivisores
            // 
            this.btnDivisores.Location = new System.Drawing.Point(79, 258);
            this.btnDivisores.Name = "btnDivisores";
            this.btnDivisores.Size = new System.Drawing.Size(75, 23);
            this.btnDivisores.TabIndex = 12;
            this.btnDivisores.Text = "ver divisores";
            this.btnDivisores.UseVisualStyleBackColor = true;
            this.btnDivisores.Click += new System.EventHandler(this.btnDivisores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(31, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "5) Divisíveis por 3 ou 4 entre 0 e 30";
            // 
            // btnFatoriais
            // 
            this.btnFatoriais.Location = new System.Drawing.Point(349, 258);
            this.btnFatoriais.Name = "btnFatoriais";
            this.btnFatoriais.Size = new System.Drawing.Size(75, 23);
            this.btnFatoriais.TabIndex = 14;
            this.btnFatoriais.Text = "ver fatoriais";
            this.btnFatoriais.UseVisualStyleBackColor = true;
            this.btnFatoriais.Click += new System.EventHandler(this.btnFatoriais_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(334, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "6) Fatoriais de 1 a 10";
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.AutoSize = true;
            this.btnFibonacci.Location = new System.Drawing.Point(78, 343);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(78, 23);
            this.btnFibonacci.TabIndex = 16;
            this.btnFibonacci.Text = "ver fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(33, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "7) ver fibonacci até passar de 100";
            // 
            // btnForsEncadeados
            // 
            this.btnForsEncadeados.Location = new System.Drawing.Point(349, 343);
            this.btnForsEncadeados.Name = "btnForsEncadeados";
            this.btnForsEncadeados.Size = new System.Drawing.Size(75, 23);
            this.btnForsEncadeados.TabIndex = 18;
            this.btnForsEncadeados.Text = "ver tabela";
            this.btnForsEncadeados.UseVisualStyleBackColor = true;
            this.btnForsEncadeados.Click += new System.EventHandler(this.btnForsEncadeados_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(334, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "8) for\'s encadeados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(512, 483);
            this.Controls.Add(this.btnForsEncadeados);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFatoriais);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDivisores);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSomaSemMult3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMult3De1A100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSoma1A1000);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSoma1A1000;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMult3De1A100;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSomaSemMult3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDivisores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFatoriais;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnForsEncadeados;
        private System.Windows.Forms.Label label9;
    }
}

