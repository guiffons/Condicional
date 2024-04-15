namespace AulaNivia_Condicional
{
    partial class Form3
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
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblsalario = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btmCalcular = new System.Windows.Forms.Button();
            this.btmLimpar = new System.Windows.Forms.Button();
            this.btmVoltar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMostrarnome = new System.Windows.Forms.TextBox();
            this.txtErro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(215, 105);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 0;
            this.lblIdade.Text = "Idade:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(217, 137);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblsalario
            // 
            this.lblsalario.AutoSize = true;
            this.lblsalario.Location = new System.Drawing.Point(216, 169);
            this.lblsalario.Name = "lblsalario";
            this.lblsalario.Size = new System.Drawing.Size(42, 13);
            this.lblsalario.TabIndex = 2;
            this.lblsalario.Text = "Salário:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(283, 97);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(100, 20);
            this.txtidade.TabIndex = 3;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(283, 130);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 20);
            this.txtSexo.TabIndex = 4;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(283, 168);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 5;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(295, 302);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(75, 23);
            this.btmCalcular.TabIndex = 6;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btmLimpar
            // 
            this.btmLimpar.Location = new System.Drawing.Point(295, 349);
            this.btmLimpar.Name = "btmLimpar";
            this.btmLimpar.Size = new System.Drawing.Size(75, 23);
            this.btmLimpar.TabIndex = 7;
            this.btmLimpar.Text = "Limpar";
            this.btmLimpar.UseVisualStyleBackColor = true;
            this.btmLimpar.Click += new System.EventHandler(this.btmLimpar_Click);
            // 
            // btmVoltar
            // 
            this.btmVoltar.Location = new System.Drawing.Point(295, 379);
            this.btmVoltar.Name = "btmVoltar";
            this.btmVoltar.Size = new System.Drawing.Size(75, 23);
            this.btmVoltar.TabIndex = 8;
            this.btmVoltar.Text = "Voltar";
            this.btmVoltar.UseVisualStyleBackColor = true;
            this.btmVoltar.Click += new System.EventHandler(this.btmVoltar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.ForeColor = System.Drawing.Color.Firebrick;
            this.lblresultado.Location = new System.Drawing.Point(159, 267);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(58, 13);
            this.lblresultado.TabIndex = 10;
            this.lblresultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(328, 263);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(183, 20);
            this.txtResultado.TabIndex = 11;
            this.txtResultado.TextChanged += new System.EventHandler(this.txtResultado_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(216, 200);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(283, 201);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(246, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Salário Liquído";
            // 
            // txtMostrarnome
            // 
            this.txtMostrarnome.Location = new System.Drawing.Point(224, 263);
            this.txtMostrarnome.Name = "txtMostrarnome";
            this.txtMostrarnome.Size = new System.Drawing.Size(100, 20);
            this.txtMostrarnome.TabIndex = 15;
            this.txtMostrarnome.Visible = false;
            // 
            // txtErro
            // 
            this.txtErro.Location = new System.Drawing.Point(283, 237);
            this.txtErro.Name = "txtErro";
            this.txtErro.Size = new System.Drawing.Size(133, 20);
            this.txtErro.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtErro);
            this.Controls.Add(this.txtMostrarnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btmVoltar);
            this.Controls.Add(this.btmLimpar);
            this.Controls.Add(this.btmCalcular);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.lblsalario);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblIdade);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblsalario;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Button btmLimpar;
        private System.Windows.Forms.Button btmVoltar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostrarnome;
        private System.Windows.Forms.TextBox txtErro;
    }
}