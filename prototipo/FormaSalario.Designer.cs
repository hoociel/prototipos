
namespace prototipo
{
    partial class FormaSalario
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
            this.textoActual = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPor = new System.Windows.Forms.Label();
            this.botonC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label1.Location = new System.Drawing.Point(153, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incremento de Salario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(155, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salario Actual";
            // 
            // textoActual
            // 
            this.textoActual.Location = new System.Drawing.Point(317, 169);
            this.textoActual.Name = "textoActual";
            this.textoActual.Size = new System.Drawing.Size(140, 20);
            this.textoActual.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(68, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salario con Incremento";
            // 
            // labelPor
            // 
            this.labelPor.AutoSize = true;
            this.labelPor.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(139)))), ((int)(((byte)(137)))));
            this.labelPor.Location = new System.Drawing.Point(315, 254);
            this.labelPor.Name = "labelPor";
            this.labelPor.Size = new System.Drawing.Size(29, 21);
            this.labelPor.TabIndex = 6;
            this.labelPor.Text = "%";
            // 
            // botonC
            // 
            this.botonC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonC.Location = new System.Drawing.Point(269, 366);
            this.botonC.Name = "botonC";
            this.botonC.Size = new System.Drawing.Size(85, 27);
            this.botonC.TabIndex = 7;
            this.botonC.Text = "Calcular";
            this.botonC.UseVisualStyleBackColor = true;
            this.botonC.Click += new System.EventHandler(this.botonC_Click);
            // 
            // FormaSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(244)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.botonC);
            this.Controls.Add(this.labelPor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaSalario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incremento de Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPor;
        private System.Windows.Forms.Button botonC;
    }
}