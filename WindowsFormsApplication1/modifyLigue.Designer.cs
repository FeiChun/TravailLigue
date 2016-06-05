namespace WindowsFormsApplication1
{
    partial class modifyLigue
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_val = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.NomBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AdrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.VilleBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CPBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.IntBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(56, 95);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_val
            // 
            this.btn_val.Location = new System.Drawing.Point(12, 333);
            this.btn_val.Name = "btn_val";
            this.btn_val.Size = new System.Drawing.Size(75, 23);
            this.btn_val.TabIndex = 1;
            this.btn_val.Text = "Valider";
            this.btn_val.UseVisualStyleBackColor = true;
            this.btn_val.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_an
            // 
            this.btn_an.Location = new System.Drawing.Point(197, 333);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(75, 23);
            this.btn_an.TabIndex = 2;
            this.btn_an.Text = "Annuler";
            this.btn_an.UseVisualStyleBackColor = true;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click);
            // 
            // NomBox
            // 
            this.NomBox.Location = new System.Drawing.Point(134, 36);
            this.NomBox.Name = "NomBox";
            this.NomBox.Size = new System.Drawing.Size(100, 20);
            this.NomBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adresse";
            // 
            // AdrBox
            // 
            this.AdrBox.Location = new System.Drawing.Point(134, 80);
            this.AdrBox.Name = "AdrBox";
            this.AdrBox.Size = new System.Drawing.Size(100, 20);
            this.AdrBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville";
            // 
            // VilleBox
            // 
            this.VilleBox.Location = new System.Drawing.Point(134, 123);
            this.VilleBox.Name = "VilleBox";
            this.VilleBox.Size = new System.Drawing.Size(100, 20);
            this.VilleBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code Postal";
            // 
            // CPBox
            // 
            this.CPBox.Location = new System.Drawing.Point(134, 167);
            this.CPBox.Name = "CPBox";
            this.CPBox.Size = new System.Drawing.Size(100, 20);
            this.CPBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Téléphone";
            // 
            // TelBox
            // 
            this.TelBox.Location = new System.Drawing.Point(134, 212);
            this.TelBox.Name = "TelBox";
            this.TelBox.Size = new System.Drawing.Size(100, 20);
            this.TelBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mail";
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(134, 255);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(100, 20);
            this.MailBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Intituler";
            // 
            // IntBox
            // 
            this.IntBox.Location = new System.Drawing.Point(134, 299);
            this.IntBox.Name = "IntBox";
            this.IntBox.Size = new System.Drawing.Size(100, 20);
            this.IntBox.TabIndex = 16;
            // 
            // modifyLigue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 368);
            this.Controls.Add(this.IntBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CPBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.VilleBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdrBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomBox);
            this.Controls.Add(this.btn_an);
            this.Controls.Add(this.btn_val);
            this.Controls.Add(this.listBox1);
            this.Name = "modifyLigue";
            this.Text = "modifyLigue";
            this.Load += new System.EventHandler(this.modifyLigue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_val;
        private System.Windows.Forms.Button btn_an;
        private System.Windows.Forms.TextBox NomBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VilleBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CPBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TelBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MailBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IntBox;
    }
}