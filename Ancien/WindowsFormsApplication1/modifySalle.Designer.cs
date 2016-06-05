namespace WindowsFormsApplication1
{
    partial class modifySalle
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
            this.lb_salle = new System.Windows.Forms.ListBox();
            this.tb_nsalle = new System.Windows.Forms.TextBox();
            this.tb_psalle = new System.Windows.Forms.TextBox();
            this.tb_permax = new System.Windows.Forms.TextBox();
            this.tb_icateg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_salle
            // 
            this.lb_salle.FormattingEnabled = true;
            this.lb_salle.Location = new System.Drawing.Point(13, 13);
            this.lb_salle.Name = "lb_salle";
            this.lb_salle.Size = new System.Drawing.Size(48, 95);
            this.lb_salle.TabIndex = 0;
            this.lb_salle.SelectedIndexChanged += new System.EventHandler(this.lb_salle_SelectedIndexChanged);
            // 
            // tb_nsalle
            // 
            this.tb_nsalle.Location = new System.Drawing.Point(108, 29);
            this.tb_nsalle.Name = "tb_nsalle";
            this.tb_nsalle.Size = new System.Drawing.Size(100, 20);
            this.tb_nsalle.TabIndex = 1;
            // 
            // tb_psalle
            // 
            this.tb_psalle.Location = new System.Drawing.Point(108, 75);
            this.tb_psalle.Name = "tb_psalle";
            this.tb_psalle.Size = new System.Drawing.Size(100, 20);
            this.tb_psalle.TabIndex = 2;
            // 
            // tb_permax
            // 
            this.tb_permax.Location = new System.Drawing.Point(108, 122);
            this.tb_permax.Name = "tb_permax";
            this.tb_permax.Size = new System.Drawing.Size(100, 20);
            this.tb_permax.TabIndex = 3;
            // 
            // tb_icateg
            // 
            this.tb_icateg.Location = new System.Drawing.Point(108, 165);
            this.tb_icateg.Name = "tb_icateg";
            this.tb_icateg.Size = new System.Drawing.Size(100, 20);
            this.tb_icateg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom Salle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "prix salle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "personne max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id Categorie";
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(13, 217);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 9;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(197, 217);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 10;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // modifySalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_icateg);
            this.Controls.Add(this.tb_permax);
            this.Controls.Add(this.tb_psalle);
            this.Controls.Add(this.tb_nsalle);
            this.Controls.Add(this.lb_salle);
            this.Name = "modifySalle";
            this.Text = "modifySalle";
            this.Load += new System.EventHandler(this.modifySalle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_salle;
        private System.Windows.Forms.TextBox tb_nsalle;
        private System.Windows.Forms.TextBox tb_psalle;
        private System.Windows.Forms.TextBox tb_permax;
        private System.Windows.Forms.TextBox tb_icateg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_annuler;
    }
}