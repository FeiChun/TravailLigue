namespace WindowsFormsApplication1
{
    partial class modifyCompte
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
            this.CompteBox = new System.Windows.Forms.ListBox();
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.MDPBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompteBox
            // 
            this.CompteBox.FormattingEnabled = true;
            this.CompteBox.Location = new System.Drawing.Point(12, 12);
            this.CompteBox.Name = "CompteBox";
            this.CompteBox.Size = new System.Drawing.Size(55, 95);
            this.CompteBox.TabIndex = 0;
            this.CompteBox.SelectedIndexChanged += new System.EventHandler(this.CompteBox_SelectedIndexChanged);
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(12, 143);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 1;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.btn_val_Click);
            // 
            // btn_an
            // 
            this.btn_an.Location = new System.Drawing.Point(138, 143);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(75, 23);
            this.btn_an.TabIndex = 2;
            this.btn_an.Text = "Annuler";
            this.btn_an.UseVisualStyleBackColor = true;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Identifiant";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(112, 44);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(100, 20);
            this.IDBox.TabIndex = 4;
            // 
            // MDPBox
            // 
            this.MDPBox.Location = new System.Drawing.Point(112, 87);
            this.MDPBox.Name = "MDPBox";
            this.MDPBox.Size = new System.Drawing.Size(100, 20);
            this.MDPBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mot de Passe";
            // 
            // modifyCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 178);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MDPBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_an);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.CompteBox);
            this.Name = "modifyCompte";
            this.Text = "modifyCompte";
            this.Load += new System.EventHandler(this.modifyCompte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CompteBox;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_an;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox MDPBox;
        private System.Windows.Forms.Label label2;
    }
}