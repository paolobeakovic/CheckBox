namespace beakovicPaoloDz1
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
            this.chkDorucak = new System.Windows.Forms.CheckBox();
            this.chkRucak = new System.Windows.Forms.CheckBox();
            this.chkVecera = new System.Windows.Forms.CheckBox();
            this.chksakri = new System.Windows.Forms.CheckBox();
            this.btnposalji = new System.Windows.Forms.Button();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkDorucak
            // 
            this.chkDorucak.AutoSize = true;
            this.chkDorucak.Location = new System.Drawing.Point(37, 49);
            this.chkDorucak.Name = "chkDorucak";
            this.chkDorucak.Size = new System.Drawing.Size(67, 17);
            this.chkDorucak.TabIndex = 0;
            this.chkDorucak.Text = "Dorucak";
            this.chkDorucak.UseVisualStyleBackColor = true;
            // 
            // chkRucak
            // 
            this.chkRucak.AutoSize = true;
            this.chkRucak.Location = new System.Drawing.Point(37, 82);
            this.chkRucak.Name = "chkRucak";
            this.chkRucak.Size = new System.Drawing.Size(58, 17);
            this.chkRucak.TabIndex = 1;
            this.chkRucak.Text = "Rucak";
            this.chkRucak.UseVisualStyleBackColor = true;
            // 
            // chkVecera
            // 
            this.chkVecera.AutoSize = true;
            this.chkVecera.Location = new System.Drawing.Point(37, 120);
            this.chkVecera.Name = "chkVecera";
            this.chkVecera.Size = new System.Drawing.Size(60, 17);
            this.chkVecera.TabIndex = 2;
            this.chkVecera.Text = "Vecera";
            this.chkVecera.UseVisualStyleBackColor = true;
            // 
            // chksakri
            // 
            this.chksakri.AutoSize = true;
            this.chksakri.Location = new System.Drawing.Point(37, 220);
            this.chksakri.Name = "chksakri";
            this.chksakri.Size = new System.Drawing.Size(99, 17);
            this.chksakri.TabIndex = 3;
            this.chksakri.Text = "Sakrij narudžbu";
            this.chksakri.UseVisualStyleBackColor = true;
            this.chksakri.CheckedChanged += new System.EventHandler(this.Chksakri_CheckedChanged);
            // 
            // btnposalji
            // 
            this.btnposalji.Location = new System.Drawing.Point(192, 205);
            this.btnposalji.Name = "btnposalji";
            this.btnposalji.Size = new System.Drawing.Size(242, 44);
            this.btnposalji.TabIndex = 4;
            this.btnposalji.Text = "Pošalji";
            this.btnposalji.UseVisualStyleBackColor = true;
            this.btnposalji.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(192, 49);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(242, 123);
            this.txtPrikaz.TabIndex = 5;
            this.txtPrikaz.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 261);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.btnposalji);
            this.Controls.Add(this.chksakri);
            this.Controls.Add(this.chkVecera);
            this.Controls.Add(this.chkRucak);
            this.Controls.Add(this.chkDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDorucak;
        private System.Windows.Forms.CheckBox chkRucak;
        private System.Windows.Forms.CheckBox chkVecera;
        private System.Windows.Forms.CheckBox chksakri;
        private System.Windows.Forms.Button btnposalji;
        private System.Windows.Forms.TextBox txtPrikaz;
    }
}

