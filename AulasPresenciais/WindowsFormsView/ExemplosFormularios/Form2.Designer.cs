namespace WindowsFormsView
{
    partial class Form2
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
            this.btnCarregarForm1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarregarForm1
            // 
            this.btnCarregarForm1.Location = new System.Drawing.Point(12, 37);
            this.btnCarregarForm1.Name = "btnCarregarForm1";
            this.btnCarregarForm1.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarForm1.TabIndex = 0;
            this.btnCarregarForm1.Text = "Abrir Form 1";
            this.btnCarregarForm1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCarregarForm1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarForm1;
    }
}