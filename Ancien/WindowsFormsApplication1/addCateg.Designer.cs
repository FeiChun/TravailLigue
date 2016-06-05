namespace WindowsFormsApplication1
{
    partial class addCateg
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
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_supr = new System.Windows.Forms.Button();
            this.tb_libcat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(33, 88);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 0;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_supr
            // 
            this.btn_supr.Location = new System.Drawing.Point(124, 88);
            this.btn_supr.Name = "btn_supr";
            this.btn_supr.Size = new System.Drawing.Size(75, 23);
            this.btn_supr.TabIndex = 1;
            this.btn_supr.Text = "Annuler";
            this.btn_supr.UseVisualStyleBackColor = true;
            this.btn_supr.Click += new System.EventHandler(this.btn_supr_Click);
            // 
            // tb_libcat
            // 
            this.tb_libcat.Location = new System.Drawing.Point(124, 48);
            this.tb_libcat.Name = "tb_libcat";
            this.tb_libcat.Size = new System.Drawing.Size(100, 20);
            this.tb_libcat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Libellé Catégorie";
            // 
            // addCateg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_libcat);
            this.Controls.Add(this.btn_supr);
            this.Controls.Add(this.btn_val);
            this.Name = "addCateg";
            this.Text = "Ajout d\'une Catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_supr;
        private System.Windows.Forms.TextBox tb_libcat;
        private System.Windows.Forms.Label label1;
    }
}