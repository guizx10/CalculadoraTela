﻿namespace CalculadoraTela
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
            this.label3 = new System.Windows.Forms.Label();
            this.numeroUm = new System.Windows.Forms.TextBox();
            this.numeroDois = new System.Windows.Forms.TextBox();
            this.somar = new System.Windows.Forms.Button();
            this.subtrair = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número: ";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Número:";
            // 
            // numeroUm
            // 
            this.numeroUm.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroUm.Location = new System.Drawing.Point(526, 56);
            this.numeroUm.Name = "numeroUm";
            this.numeroUm.Size = new System.Drawing.Size(186, 31);
            this.numeroUm.TabIndex = 3;
            this.numeroUm.TextChanged += new System.EventHandler(this.numeroUm_TextChanged);
            // 
            // numeroDois
            // 
            this.numeroDois.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDois.Location = new System.Drawing.Point(526, 105);
            this.numeroDois.Name = "numeroDois";
            this.numeroDois.Size = new System.Drawing.Size(186, 31);
            this.numeroDois.TabIndex = 4;
            this.numeroDois.TextChanged += new System.EventHandler(this.numeroDois_TextChanged);
            // 
            // somar
            // 
            this.somar.Location = new System.Drawing.Point(349, 218);
            this.somar.Name = "somar";
            this.somar.Size = new System.Drawing.Size(103, 51);
            this.somar.TabIndex = 5;
            this.somar.Text = "+";
            this.somar.UseVisualStyleBackColor = true;
            this.somar.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtrair
            // 
            this.subtrair.Location = new System.Drawing.Point(492, 218);
            this.subtrair.Name = "subtrair";
            this.subtrair.Size = new System.Drawing.Size(102, 51);
            this.subtrair.TabIndex = 6;
            this.subtrair.Text = "-";
            this.subtrair.UseVisualStyleBackColor = true;
            this.subtrair.Click += new System.EventHandler(this.subtrair_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(349, 279);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(103, 51);
            this.dividir.TabIndex = 7;
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.button3_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(492, 281);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(102, 49);
            this.multiplicar.TabIndex = 8;
            this.multiplicar.Text = "*";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.button4_Click);
            // 
            // limpar
            // 
            this.limpar.ForeColor = System.Drawing.Color.Black;
            this.limpar.Location = new System.Drawing.Point(336, 337);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(276, 51);
            this.limpar.TabIndex = 9;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.button5_Click);
            // 
            // resultado
            // 
            this.resultado.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(312, 167);
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.Size = new System.Drawing.Size(317, 31);
            this.resultado.TabIndex = 11;
            this.resultado.TextChanged += new System.EventHandler(this.resultado_TextChanged);
            // 
            // Form1
            // 
            this.AccessibleDescription = "Software destinado a realizar calculos basicos";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(908, 400);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.subtrair);
            this.Controls.Add(this.somar);
            this.Controls.Add(this.numeroDois);
            this.Controls.Add(this.numeroUm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximumSize = new System.Drawing.Size(924, 439);
            this.MinimumSize = new System.Drawing.Size(924, 439);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página Principal ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroUm;
        private System.Windows.Forms.TextBox numeroDois;
        private System.Windows.Forms.Button somar;
        private System.Windows.Forms.Button subtrair;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.TextBox resultado;
    }
}

