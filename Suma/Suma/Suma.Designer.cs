
namespace Suma
{
    partial class Suma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.Sumarbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(169, 29);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(71, 20);
            this.Numero1textBox.TabIndex = 2;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(169, 57);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(71, 20);
            this.Numero2textBox.TabIndex = 3;
            // 
            // Sumarbutton1
            // 
            this.Sumarbutton1.Location = new System.Drawing.Point(169, 97);
            this.Sumarbutton1.Name = "Sumarbutton1";
            this.Sumarbutton1.Size = new System.Drawing.Size(71, 24);
            this.Sumarbutton1.TabIndex = 4;
            this.Sumarbutton1.Text = "Sumar";
            this.Sumarbutton1.UseVisualStyleBackColor = true;
            this.Sumarbutton1.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Numero 2";
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 235);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sumarbutton1);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.label1);
            this.Name = "Suma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.Button Sumarbutton1;
        private System.Windows.Forms.Label label2;
    }
}

