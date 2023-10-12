
namespace prototipo
{
    partial class FormaCuadratica
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textoA = new System.Windows.Forms.TextBox();
            this.textoB = new System.Windows.Forms.TextBox();
            this.textoC = new System.Windows.Forms.TextBox();
            this.buttonCua = new System.Windows.Forms.Button();
            this.labelUno = new System.Windows.Forms.Label();
            this.labelDos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(162, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formula Cuadratica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(105, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Valor A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(104, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(105, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor C";
            // 
            // textoA
            // 
            this.textoA.Location = new System.Drawing.Point(263, 152);
            this.textoA.Name = "textoA";
            this.textoA.Size = new System.Drawing.Size(148, 20);
            this.textoA.TabIndex = 9;
            // 
            // textoB
            // 
            this.textoB.Location = new System.Drawing.Point(263, 232);
            this.textoB.Name = "textoB";
            this.textoB.Size = new System.Drawing.Size(148, 20);
            this.textoB.TabIndex = 10;
            // 
            // textoC
            // 
            this.textoC.Location = new System.Drawing.Point(263, 310);
            this.textoC.Name = "textoC";
            this.textoC.Size = new System.Drawing.Size(148, 20);
            this.textoC.TabIndex = 11;
            // 
            // buttonCua
            // 
            this.buttonCua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCua.Location = new System.Drawing.Point(497, 171);
            this.buttonCua.Name = "buttonCua";
            this.buttonCua.Size = new System.Drawing.Size(90, 24);
            this.buttonCua.TabIndex = 12;
            this.buttonCua.Text = "Calcular";
            this.buttonCua.UseVisualStyleBackColor = true;
            this.buttonCua.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelUno
            // 
            this.labelUno.AutoSize = true;
            this.labelUno.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.labelUno.Location = new System.Drawing.Point(473, 229);
            this.labelUno.Name = "labelUno";
            this.labelUno.Size = new System.Drawing.Size(33, 21);
            this.labelUno.TabIndex = 13;
            this.labelUno.Text = "x1";
            // 
            // labelDos
            // 
            this.labelDos.AutoSize = true;
            this.labelDos.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.labelDos.Location = new System.Drawing.Point(473, 288);
            this.labelDos.Name = "labelDos";
            this.labelDos.Size = new System.Drawing.Size(33, 21);
            this.labelDos.TabIndex = 14;
            this.labelDos.Text = "x2";
            // 
            // FormaCuadratica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.labelDos);
            this.Controls.Add(this.labelUno);
            this.Controls.Add(this.buttonCua);
            this.Controls.Add(this.textoC);
            this.Controls.Add(this.textoB);
            this.Controls.Add(this.textoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaCuadratica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formula Cuadratica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoA;
        private System.Windows.Forms.TextBox textoB;
        private System.Windows.Forms.TextBox textoC;
        private System.Windows.Forms.Button buttonCua;
        private System.Windows.Forms.Label labelUno;
        private System.Windows.Forms.Label labelDos;
    }
}