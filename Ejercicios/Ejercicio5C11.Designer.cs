namespace Ejercicios
{
    partial class Ejercicio5C11
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
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.RutaTextBox = new System.Windows.Forms.TextBox();
            this.NuevoNombreTextBox = new System.Windows.Forms.TextBox();
            this.CambiarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta del archivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nuevo Nombre del archivo";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(152, 32);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NombreTextBox.TabIndex = 3;
            // 
            // RutaTextBox
            // 
            this.RutaTextBox.Location = new System.Drawing.Point(152, 68);
            this.RutaTextBox.Name = "RutaTextBox";
            this.RutaTextBox.Size = new System.Drawing.Size(100, 20);
            this.RutaTextBox.TabIndex = 4;
            // 
            // NuevoNombreTextBox
            // 
            this.NuevoNombreTextBox.Location = new System.Drawing.Point(152, 105);
            this.NuevoNombreTextBox.Name = "NuevoNombreTextBox";
            this.NuevoNombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.NuevoNombreTextBox.TabIndex = 5;
            // 
            // CambiarButton
            // 
            this.CambiarButton.Location = new System.Drawing.Point(152, 156);
            this.CambiarButton.Name = "CambiarButton";
            this.CambiarButton.Size = new System.Drawing.Size(100, 23);
            this.CambiarButton.TabIndex = 6;
            this.CambiarButton.Text = "Cambiar nombre";
            this.CambiarButton.UseVisualStyleBackColor = true;
            this.CambiarButton.Click += new System.EventHandler(this.CambiarButton_Click);
            // 
            // Ejercicio5C11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CambiarButton);
            this.Controls.Add(this.NuevoNombreTextBox);
            this.Controls.Add(this.RutaTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio5C11";
            this.Text = "Ejercicio 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox RutaTextBox;
        private System.Windows.Forms.TextBox NuevoNombreTextBox;
        private System.Windows.Forms.Button CambiarButton;
    }
}