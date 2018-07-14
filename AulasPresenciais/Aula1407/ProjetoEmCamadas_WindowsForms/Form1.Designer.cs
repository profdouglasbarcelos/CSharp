namespace ProjetoEmCamadas_WindowsForms
{
    partial class Form1
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
            this.btnCadastroCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCategoria
            // 
            this.btnCadastroCategoria.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroCategoria.Name = "btnCadastroCategoria";
            this.btnCadastroCategoria.Size = new System.Drawing.Size(128, 23);
            this.btnCadastroCategoria.TabIndex = 0;
            this.btnCadastroCategoria.Text = "Cadastrar Categoria";
            this.btnCadastroCategoria.UseVisualStyleBackColor = true;
            this.btnCadastroCategoria.Click += new System.EventHandler(this.btnCadastroCategoria_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCadastroCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCategoria;
    }
}

