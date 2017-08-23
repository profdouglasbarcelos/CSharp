namespace Aula1003_WF2
{
    partial class frmFilho
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
            this.button1 = new System.Windows.Forms.Button();
            this.ucEndereco2 = new Aula1003_WF2.ucEndereco();
            this.ucEnd1 = new Aula1003_WF2.ucEndereco();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ucEndereco2
            // 
            this.ucEndereco2.Location = new System.Drawing.Point(12, 138);
            this.ucEndereco2.Name = "ucEndereco2";
            this.ucEndereco2.nomeRua = "";
            this.ucEndereco2.Size = new System.Drawing.Size(172, 90);
            this.ucEndereco2.TabIndex = 2;
            // 
            // ucEnd1
            // 
            this.ucEnd1.Location = new System.Drawing.Point(136, 31);
            this.ucEnd1.Name = "ucEnd1";
            this.ucEnd1.nomeRua = "";
            this.ucEnd1.Size = new System.Drawing.Size(172, 90);
            this.ucEnd1.TabIndex = 1;
            // 
            // frmFilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 384);
            this.Controls.Add(this.ucEndereco2);
            this.Controls.Add(this.ucEnd1);
            this.Controls.Add(this.button1);
            this.Name = "frmFilho";
            this.Text = "frmFilho";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private ucEndereco ucEnd1;
        private ucEndereco ucEndereco2;
        //private ucEndereco _ucEndereco;
    }
}