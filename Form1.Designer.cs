
namespace Función_IF
{
    partial class Form1
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
            this.Botónparaedad = new System.Windows.Forms.TextBox();
            this.Botoncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su edad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Botónparaedad
            // 
            this.Botónparaedad.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botónparaedad.Location = new System.Drawing.Point(509, 36);
            this.Botónparaedad.Name = "Botónparaedad";
            this.Botónparaedad.Size = new System.Drawing.Size(511, 50);
            this.Botónparaedad.TabIndex = 1;
            // 
            // Botoncalcular
            // 
            this.Botoncalcular.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botoncalcular.Location = new System.Drawing.Point(436, 125);
            this.Botoncalcular.Name = "Botoncalcular";
            this.Botoncalcular.Size = new System.Drawing.Size(136, 39);
            this.Botoncalcular.TabIndex = 2;
            this.Botoncalcular.Text = "Calcular";
            this.Botoncalcular.UseVisualStyleBackColor = true;
            this.Botoncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Botoncalcular);
            this.Controls.Add(this.Botónparaedad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Edad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Botónparaedad;
        private System.Windows.Forms.Button Botoncalcular;
    }
}

