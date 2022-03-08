
namespace TrindadeMDC
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
            this.textValue1 = new System.Windows.Forms.TextBox();
            this.textValue2 = new System.Windows.Forms.TextBox();
            this.lbInsiraNum1 = new System.Windows.Forms.Label();
            this.lbInsiraNum2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValue1
            // 
            this.textValue1.BackColor = System.Drawing.SystemColors.Window;
            this.textValue1.Location = new System.Drawing.Point(27, 123);
            this.textValue1.Name = "textValue1";
            this.textValue1.Size = new System.Drawing.Size(120, 20);
            this.textValue1.TabIndex = 0;
            // 
            // textValue2
            // 
            this.textValue2.Location = new System.Drawing.Point(27, 198);
            this.textValue2.Name = "textValue2";
            this.textValue2.Size = new System.Drawing.Size(120, 20);
            this.textValue2.TabIndex = 1;
            // 
            // lbInsiraNum1
            // 
            this.lbInsiraNum1.AutoSize = true;
            this.lbInsiraNum1.Location = new System.Drawing.Point(24, 91);
            this.lbInsiraNum1.Name = "lbInsiraNum1";
            this.lbInsiraNum1.Size = new System.Drawing.Size(87, 13);
            this.lbInsiraNum1.TabIndex = 2;
            this.lbInsiraNum1.Text = "Insira um numero";
            // 
            // lbInsiraNum2
            // 
            this.lbInsiraNum2.AutoSize = true;
            this.lbInsiraNum2.Location = new System.Drawing.Point(24, 168);
            this.lbInsiraNum2.Name = "lbInsiraNum2";
            this.lbInsiraNum2.Size = new System.Drawing.Size(123, 13);
            this.lbInsiraNum2.TabIndex = 3;
            this.lbInsiraNum2.Text = "Insira o segundo numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calculo MDC (Maior divisor comum)";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(249, 31);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(252, 233);
            this.textResultado.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(27, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 290);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbInsiraNum2);
            this.Controls.Add(this.lbInsiraNum1);
            this.Controls.Add(this.textValue2);
            this.Controls.Add(this.textValue1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValue1;
        private System.Windows.Forms.TextBox textValue2;
        private System.Windows.Forms.Label lbInsiraNum1;
        private System.Windows.Forms.Label lbInsiraNum2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

