namespace Exercicio9P8
{
    partial class FormCadastroConta
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.btCancelarCadastro = new System.Windows.Forms.Button();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(118, 66);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(121, 20);
            this.textoTitular.TabIndex = 3;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(164, 135);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(118, 92);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 5;
            // 
            // btCancelarCadastro
            // 
            this.btCancelarCadastro.Location = new System.Drawing.Point(37, 135);
            this.btCancelarCadastro.Name = "btCancelarCadastro";
            this.btCancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btCancelarCadastro.TabIndex = 6;
            this.btCancelarCadastro.Text = "Cancelar";
            this.btCancelarCadastro.UseVisualStyleBackColor = true;
            this.btCancelarCadastro.Click += new System.EventHandler(this.btCancelarCadastro_Click);
            // 
            // textoNumero
            // 
            this.textoNumero.Enabled = false;
            this.textoNumero.Location = new System.Drawing.Point(118, 40);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.ReadOnly = true;
            this.textoNumero.Size = new System.Drawing.Size(121, 20);
            this.textoNumero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(273, 197);
            this.Controls.Add(this.btCancelarCadastro);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button btCancelarCadastro;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label1;
    }
}