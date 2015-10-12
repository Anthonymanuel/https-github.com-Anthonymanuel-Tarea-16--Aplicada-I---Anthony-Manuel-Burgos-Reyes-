namespace Ejercicios
{
    partial class Ejercicio3C11
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.RutaActualTextBox = new System.Windows.Forms.TextBox();
            this.NuevaRutaTextBox = new System.Windows.Forms.TextBox();
            this.CopiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nueva ruta del archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta del archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del archivo a copiar";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(176, 24);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(144, 20);
            this.NombreTextBox.TabIndex = 4;
            // 
            // RutaActualTextBox
            // 
            this.RutaActualTextBox.Location = new System.Drawing.Point(176, 56);
            this.RutaActualTextBox.Name = "RutaActualTextBox";
            this.RutaActualTextBox.Size = new System.Drawing.Size(144, 20);
            this.RutaActualTextBox.TabIndex = 5;
            // 
            // NuevaRutaTextBox
            // 
            this.NuevaRutaTextBox.Location = new System.Drawing.Point(176, 93);
            this.NuevaRutaTextBox.Name = "NuevaRutaTextBox";
            this.NuevaRutaTextBox.Size = new System.Drawing.Size(144, 20);
            this.NuevaRutaTextBox.TabIndex = 6;
            // 
            // CopiarButton
            // 
            this.CopiarButton.Location = new System.Drawing.Point(122, 143);
            this.CopiarButton.Name = "CopiarButton";
            this.CopiarButton.Size = new System.Drawing.Size(75, 23);
            this.CopiarButton.TabIndex = 7;
            this.CopiarButton.Text = "Copiar";
            this.CopiarButton.UseVisualStyleBackColor = true;
            this.CopiarButton.Click += new System.EventHandler(this.CopiarButton_Click);
            // 
            // Ejercicio3C4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 261);
            this.Controls.Add(this.CopiarButton);
            this.Controls.Add(this.NuevaRutaTextBox);
            this.Controls.Add(this.RutaActualTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio3C4";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox RutaActualTextBox;
        private System.Windows.Forms.TextBox NuevaRutaTextBox;
        private System.Windows.Forms.Button CopiarButton;
    }
}