namespace Interfaz
{
    partial class Vista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.lbresultado = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(378, 99);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(100, 23);
            this.txtvalor1.TabIndex = 0;
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(378, 141);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(100, 23);
            this.txtvalor2.TabIndex = 1;
            // 
            // lbresultado
            // 
            this.lbresultado.AutoSize = true;
            this.lbresultado.Location = new System.Drawing.Point(413, 221);
            this.lbresultado.Name = "lbresultado";
            this.lbresultado.Size = new System.Drawing.Size(38, 15);
            this.lbresultado.TabIndex = 2;
            this.lbresultado.Text = "label1";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(385, 179);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbresultado);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.txtvalor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.Label lbresultado;
        private System.Windows.Forms.Button btncalcular;
    }
}

