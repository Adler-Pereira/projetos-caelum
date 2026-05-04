namespace Exercicios3P5
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerPi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvPi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcBhaskara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(56, 120);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(176, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EXERCÍCIOS 3.5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(179, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2)";
            // 
            // btnVerPi
            // 
            this.btnVerPi.Location = new System.Drawing.Point(182, 120);
            this.btnVerPi.Name = "btnVerPi";
            this.btnVerPi.Size = new System.Drawing.Size(75, 23);
            this.btnVerPi.TabIndex = 4;
            this.btnVerPi.Text = "ver pi";
            this.btnVerPi.UseVisualStyleBackColor = true;
            this.btnVerPi.Click += new System.EventHandler(this.btnVerPi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(314, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "3)";
            // 
            // btnConvPi
            // 
            this.btnConvPi.Location = new System.Drawing.Point(317, 120);
            this.btnConvPi.Name = "btnConvPi";
            this.btnConvPi.Size = new System.Drawing.Size(75, 23);
            this.btnConvPi.TabIndex = 6;
            this.btnConvPi.Text = "converter pi";
            this.btnConvPi.UseVisualStyleBackColor = true;
            this.btnConvPi.Click += new System.EventHandler(this.btnConvPi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(53, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "idadeJoao = 10\r\nidadeMaria = 25\r\nidadeJose = 42";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(37, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "3)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(53, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "a = 2\r\nb = -7\r\nc = 3";
            // 
            // btnCalcBhaskara
            // 
            this.btnCalcBhaskara.AutoSize = true;
            this.btnCalcBhaskara.Location = new System.Drawing.Point(56, 232);
            this.btnCalcBhaskara.Name = "btnCalcBhaskara";
            this.btnCalcBhaskara.Size = new System.Drawing.Size(101, 23);
            this.btnCalcBhaskara.TabIndex = 10;
            this.btnCalcBhaskara.Text = "calcular bhaskara";
            this.btnCalcBhaskara.UseVisualStyleBackColor = true;
            this.btnCalcBhaskara.Click += new System.EventHandler(this.btnCalcBhaskara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(428, 303);
            this.Controls.Add(this.btnCalcBhaskara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConvPi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerPi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerPi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvPi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalcBhaskara;
    }
}

