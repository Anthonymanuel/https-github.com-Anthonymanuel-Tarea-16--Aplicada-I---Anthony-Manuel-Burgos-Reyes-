namespace Ejercicios
{
    partial class Ejercicio1C12
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
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.FactorialButton = new System.Windows.Forms.Button();
            this.MostrarRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(114, 37);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroTextBox.TabIndex = 1;
            // 
            // FactorialButton
            // 
            this.FactorialButton.Location = new System.Drawing.Point(123, 76);
            this.FactorialButton.Name = "FactorialButton";
            this.FactorialButton.Size = new System.Drawing.Size(75, 23);
            this.FactorialButton.TabIndex = 2;
            this.FactorialButton.Text = "Factorial";
            this.FactorialButton.UseVisualStyleBackColor = true;
            this.FactorialButton.Click += new System.EventHandler(this.FactorialButton_Click);
            // 
            // MostrarRichTextBox
            // 
            this.MostrarRichTextBox.Location = new System.Drawing.Point(114, 153);
            this.MostrarRichTextBox.Name = "MostrarRichTextBox";
            this.MostrarRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.MostrarRichTextBox.TabIndex = 3;
            this.MostrarRichTextBox.Text = "";
            // 
            // Ejercicio1C12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MostrarRichTextBox);
            this.Controls.Add(this.FactorialButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio1C12";
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Button FactorialButton;
        private System.Windows.Forms.RichTextBox MostrarRichTextBox;
    }
}