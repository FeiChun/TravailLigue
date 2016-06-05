namespace WindowsFormsApplication1
{
    partial class addCompte
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
            this.btn_annul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_mdp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(39, 135);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 0;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_annul
            // 
            this.btn_annul.Location = new System.Drawing.Point(146, 135);
            this.btn_annul.Name = "btn_annul";
            this.btn_annul.Size = new System.Drawing.Size(75, 23);
            this.btn_annul.TabIndex = 1;
            this.btn_annul.Text = "Annuler";
            this.btn_annul.UseVisualStyleBackColor = true;
            this.btn_annul.Click += new System.EventHandler(this.btn_annul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(121, 41);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 4;
            // 
            // tb_mdp
            // 
            this.tb_mdp.Location = new System.Drawing.Point(121, 84);
            this.tb_mdp.Name = "tb_mdp";
            this.tb_mdp.Size = new System.Drawing.Size(100, 20);
            this.tb_mdp.TabIndex = 5;
            // 
            // addCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 200);
            this.Controls.Add(this.tb_mdp);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_annul);
            this.Controls.Add(this.btn_val);
            this.Name = "addCompte";
            this.Text = "Création de compte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_annul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_mdp;
    }
}