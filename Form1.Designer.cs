﻿
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
            this.cajadetexto1 = new System.Windows.Forms.TextBox();
            this.Botoncalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cajadetexto2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa número #1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cajadetexto1
            // 
            this.cajadetexto1.Font = new System.Drawing.Font("Old English Text MT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajadetexto1.Location = new System.Drawing.Point(696, 44);
            this.cajadetexto1.Name = "cajadetexto1";
            this.cajadetexto1.Size = new System.Drawing.Size(200, 50);
            this.cajadetexto1.TabIndex = 1;
            // 
            // Botoncalcular
            // 
            this.Botoncalcular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Botoncalcular.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botoncalcular.Location = new System.Drawing.Point(729, 191);
            this.Botoncalcular.Name = "Botoncalcular";
            this.Botoncalcular.Size = new System.Drawing.Size(136, 39);
            this.Botoncalcular.TabIndex = 2;
            this.Botoncalcular.Text = "Calcular";
            this.Botoncalcular.UseVisualStyleBackColor = false;
            this.Botoncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(547, 77);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa número #2";
            // 
            // cajadetexto2
            // 
            this.cajadetexto2.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajadetexto2.Location = new System.Drawing.Point(696, 124);
            this.cajadetexto2.Name = "cajadetexto2";
            this.cajadetexto2.Size = new System.Drawing.Size(200, 46);
            this.cajadetexto2.TabIndex = 4;
            this.cajadetexto2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cajadetexto2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Botoncalcular);
            this.Controls.Add(this.cajadetexto1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculo exámen final";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajadetexto1;
        private System.Windows.Forms.Button Botoncalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cajadetexto2;
    }
}

