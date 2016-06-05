namespace WindowsFormsApplication1
{
    partial class addSalle
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
            this.tb_lib = new System.Windows.Forms.TextBox();
            this.tb_px = new System.Windows.Forms.TextBox();
            this.tb_pers = new System.Windows.Forms.TextBox();
            this.lstCateg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_lib
            // 
            this.tb_lib.Location = new System.Drawing.Point(116, 57);
            this.tb_lib.Name = "tb_lib";
            this.tb_lib.Size = new System.Drawing.Size(100, 20);
            this.tb_lib.TabIndex = 0;
            // 
            // tb_px
            // 
            this.tb_px.Location = new System.Drawing.Point(116, 98);
            this.tb_px.Name = "tb_px";
            this.tb_px.Size = new System.Drawing.Size(100, 20);
            this.tb_px.TabIndex = 1;
            // 
            // tb_pers
            // 
            this.tb_pers.Location = new System.Drawing.Point(116, 141);
            this.tb_pers.Name = "tb_pers";
            this.tb_pers.Size = new System.Drawing.Size(100, 20);
            this.tb_pers.TabIndex = 2;
            // 
            // lstCateg
            // 
            this.lstCateg.FormattingEnabled = true;
            this.lstCateg.Location = new System.Drawing.Point(250, 95);
            this.lstCateg.Name = "lstCateg";
            this.lstCateg.Size = new System.Drawing.Size(97, 69);
            this.lstCateg.TabIndex = 3;
            this.lstCateg.SelectedIndexChanged += new System.EventHandler(this.lstCateg_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Libellé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personne Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Catégorie";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addSalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCateg);
            this.Controls.Add(this.tb_pers);
            this.Controls.Add(this.tb_px);
            this.Controls.Add(this.tb_lib);
            this.Name = "addSalle";
            this.Text = "addSalle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_lib;
        private System.Windows.Forms.TextBox tb_px;
        private System.Windows.Forms.TextBox tb_pers;
        private System.Windows.Forms.ListBox lstCateg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}