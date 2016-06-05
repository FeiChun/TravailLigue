namespace WindowsFormsApplication1
{
    partial class Affichage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Affichage));
            this.tab_salles = new System.Windows.Forms.TabControl();
            this.tb_salles = new System.Windows.Forms.TabPage();
            this.datagrid_salles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_reservations = new System.Windows.Forms.TabPage();
            this.datagrid_reservations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_ligues = new System.Windows.Forms.TabPage();
            this.datagrid_ligues = new System.Windows.Forms.DataGridView();
            this.idligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adrligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intitligue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuLivre = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajouterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégorieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ligueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.log = new System.Windows.Forms.TextBox();
            this.tab_salles.SuspendLayout();
            this.tb_salles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_salles)).BeginInit();
            this.tab_reservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_reservations)).BeginInit();
            this.tab_ligues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ligues)).BeginInit();
            this.menuLivre.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_salles
            // 
            this.tab_salles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_salles.Controls.Add(this.tb_salles);
            this.tab_salles.Controls.Add(this.tab_reservations);
            this.tab_salles.Controls.Add(this.tab_ligues);
            this.tab_salles.Location = new System.Drawing.Point(0, 27);
            this.tab_salles.Name = "tab_salles";
            this.tab_salles.SelectedIndex = 0;
            this.tab_salles.Size = new System.Drawing.Size(858, 376);
            this.tab_salles.TabIndex = 0;
            this.tab_salles.SelectedIndexChanged += new System.EventHandler(this.tab_salles_SelectedIndexChanged);
            // 
            // tb_salles
            // 
            this.tb_salles.Controls.Add(this.datagrid_salles);
            this.tb_salles.Location = new System.Drawing.Point(4, 22);
            this.tb_salles.Name = "tb_salles";
            this.tb_salles.Padding = new System.Windows.Forms.Padding(3);
            this.tb_salles.Size = new System.Drawing.Size(850, 350);
            this.tb_salles.TabIndex = 0;
            this.tb_salles.Text = "Salles";
            this.tb_salles.UseVisualStyleBackColor = true;
            // 
            // datagrid_salles
            // 
            this.datagrid_salles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datagrid_salles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_salles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Personne});
            this.datagrid_salles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_salles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagrid_salles.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_salles.Location = new System.Drawing.Point(3, 3);
            this.datagrid_salles.Name = "datagrid_salles";
            this.datagrid_salles.ReadOnly = true;
            this.datagrid_salles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagrid_salles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagrid_salles.Size = new System.Drawing.Size(844, 344);
            this.datagrid_salles.TabIndex = 0;
            this.datagrid_salles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_salles_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IdSalle";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Libelle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Prix";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Personne
            // 
            this.Personne.HeaderText = "Capacité (pers.)";
            this.Personne.Name = "Personne";
            this.Personne.ReadOnly = true;
            // 
            // tab_reservations
            // 
            this.tab_reservations.Controls.Add(this.datagrid_reservations);
            this.tab_reservations.Location = new System.Drawing.Point(4, 22);
            this.tab_reservations.Name = "tab_reservations";
            this.tab_reservations.Padding = new System.Windows.Forms.Padding(3);
            this.tab_reservations.Size = new System.Drawing.Size(850, 350);
            this.tab_reservations.TabIndex = 1;
            this.tab_reservations.Text = "Réservations";
            this.tab_reservations.UseVisualStyleBackColor = true;
            // 
            // datagrid_reservations
            // 
            this.datagrid_reservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_reservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.date});
            this.datagrid_reservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_reservations.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_reservations.Location = new System.Drawing.Point(3, 3);
            this.datagrid_reservations.Name = "datagrid_reservations";
            this.datagrid_reservations.Size = new System.Drawing.Size(844, 344);
            this.datagrid_reservations.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "iDRéservation";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "idLigue";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "idSalle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // date
            // 
            this.date.HeaderText = "Date Réservation";
            this.date.Name = "date";
            // 
            // tab_ligues
            // 
            this.tab_ligues.Controls.Add(this.datagrid_ligues);
            this.tab_ligues.Location = new System.Drawing.Point(4, 22);
            this.tab_ligues.Name = "tab_ligues";
            this.tab_ligues.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ligues.Size = new System.Drawing.Size(850, 350);
            this.tab_ligues.TabIndex = 2;
            this.tab_ligues.Text = "Ligues";
            this.tab_ligues.UseVisualStyleBackColor = true;
            // 
            // datagrid_ligues
            // 
            this.datagrid_ligues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_ligues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idligue,
            this.nomligue,
            this.adrligue,
            this.villeligue,
            this.cpligue,
            this.telligue,
            this.mailligue,
            this.intitligue});
            this.datagrid_ligues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_ligues.GridColor = System.Drawing.SystemColors.Control;
            this.datagrid_ligues.Location = new System.Drawing.Point(3, 3);
            this.datagrid_ligues.Name = "datagrid_ligues";
            this.datagrid_ligues.Size = new System.Drawing.Size(844, 344);
            this.datagrid_ligues.TabIndex = 1;
            // 
            // idligue
            // 
            this.idligue.HeaderText = "ID Ligue";
            this.idligue.Name = "idligue";
            // 
            // nomligue
            // 
            this.nomligue.HeaderText = "Nom";
            this.nomligue.Name = "nomligue";
            // 
            // adrligue
            // 
            this.adrligue.HeaderText = "Adresse";
            this.adrligue.Name = "adrligue";
            // 
            // villeligue
            // 
            this.villeligue.HeaderText = "Ville";
            this.villeligue.Name = "villeligue";
            // 
            // cpligue
            // 
            this.cpligue.HeaderText = "Code Postal";
            this.cpligue.Name = "cpligue";
            // 
            // telligue
            // 
            this.telligue.HeaderText = "Téléphone";
            this.telligue.Name = "telligue";
            // 
            // mailligue
            // 
            this.mailligue.HeaderText = "E-Mail";
            this.mailligue.Name = "mailligue";
            // 
            // intitligue
            // 
            this.intitligue.HeaderText = "Intitulé ?";
            this.intitligue.Name = "intitligue";
            // 
            // menuLivre
            // 
            this.menuLivre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem1,
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.menuLivre.Name = "menuLivre";
            this.menuLivre.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuLivre.Size = new System.Drawing.Size(130, 70);
            // 
            // ajouterToolStripMenuItem1
            // 
            this.ajouterToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ajouterToolStripMenuItem1.Image")));
            this.ajouterToolStripMenuItem1.Name = "ajouterToolStripMenuItem1";
            this.ajouterToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem1.Text = "Ajouter";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modifierToolStripMenuItem.Image")));
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Visible = false;
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supprimerToolStripMenuItem.Image")));
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.actionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déconnexionToolStripMenuItem,
            this.quitterToolStripMenuItem1});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.déconnexionToolStripMenuItem.Text = "Déconnexion...";
            this.déconnexionToolStripMenuItem.Click += new System.EventHandler(this.déconnexionToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutToolStripMenuItem,
            this.modificationToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // ajoutToolStripMenuItem
            // 
            this.ajoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégorieToolStripMenuItem,
            this.salleToolStripMenuItem,
            this.ligueToolStripMenuItem});
            this.ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            this.ajoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ajoutToolStripMenuItem.Text = "Ajout";
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.catégorieToolStripMenuItem.Text = "Catégorie";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.catégorieToolStripMenuItem_Click_1);
            // 
            // salleToolStripMenuItem
            // 
            this.salleToolStripMenuItem.Name = "salleToolStripMenuItem";
            this.salleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.salleToolStripMenuItem.Text = "Salle";
            this.salleToolStripMenuItem.Click += new System.EventHandler(this.salleToolStripMenuItem_Click_1);
            // 
            // ligueToolStripMenuItem
            // 
            this.ligueToolStripMenuItem.Name = "ligueToolStripMenuItem";
            this.ligueToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.ligueToolStripMenuItem.Text = "Ligue";
            this.ligueToolStripMenuItem.Click += new System.EventHandler(this.ligueToolStripMenuItem_Click_1);
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégorieToolStripMenuItem1,
            this.salleToolStripMenuItem1,
            this.ligueToolStripMenuItem1,
            this.compteToolStripMenuItem1});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // catégorieToolStripMenuItem1
            // 
            this.catégorieToolStripMenuItem1.Name = "catégorieToolStripMenuItem1";
            this.catégorieToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.catégorieToolStripMenuItem1.Text = "Catégorie";
            this.catégorieToolStripMenuItem1.Click += new System.EventHandler(this.catégorieToolStripMenuItem1_Click);
            // 
            // salleToolStripMenuItem1
            // 
            this.salleToolStripMenuItem1.Name = "salleToolStripMenuItem1";
            this.salleToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.salleToolStripMenuItem1.Text = "Salle";
            this.salleToolStripMenuItem1.Click += new System.EventHandler(this.salleToolStripMenuItem1_Click);
            // 
            // ligueToolStripMenuItem1
            // 
            this.ligueToolStripMenuItem1.Name = "ligueToolStripMenuItem1";
            this.ligueToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.ligueToolStripMenuItem1.Text = "Ligue";
            this.ligueToolStripMenuItem1.Click += new System.EventHandler(this.ligueToolStripMenuItem1_Click);
            // 
            // compteToolStripMenuItem1
            // 
            this.compteToolStripMenuItem1.Name = "compteToolStripMenuItem1";
            this.compteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.compteToolStripMenuItem1.Text = "Compte";
            this.compteToolStripMenuItem1.Click += new System.EventHandler(this.compteToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aProposToolStripMenuItem.Text = "A propos...";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // log
            // 
            this.log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.log.Enabled = false;
            this.log.Location = new System.Drawing.Point(0, 403);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log.Size = new System.Drawing.Size(852, 43);
            this.log.TabIndex = 3;
            this.log.Text = "Ne sert à rien !";
            // 
            // Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 447);
            this.Controls.Add(this.log);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tab_salles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Affichage";
            this.Text = "Affichage";
            this.Load += new System.EventHandler(this.Affichage_Load);
            this.tab_salles.ResumeLayout(false);
            this.tb_salles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_salles)).EndInit();
            this.tab_reservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_reservations)).EndInit();
            this.tab_ligues.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_ligues)).EndInit();
            this.menuLivre.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_salles;
        private System.Windows.Forms.TabPage tb_salles;
        private System.Windows.Forms.TabPage tab_reservations;
        private System.Windows.Forms.TabPage tab_ligues;
        private System.Windows.Forms.DataGridView datagrid_reservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridView datagrid_ligues;
        private System.Windows.Forms.DataGridViewTextBoxColumn idligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn adrligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn telligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailligue;
        private System.Windows.Forms.DataGridViewTextBoxColumn intitligue;
        private System.Windows.Forms.ContextMenuStrip menuLivre;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ligueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compteToolStripMenuItem1;
        private System.Windows.Forms.DataGridView datagrid_salles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personne;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
    }
}