using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Affichage : Form
    {
        public Affichage()
        {
            InitializeComponent();
        }
        public void RefreshContent()
        {
            datagrid_salles.Rows.Clear();
            datagrid_reservations.Rows.Clear();
            datagrid_ligues.Rows.Clear();

            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var listeSalle = from s in context.tsalles
                                select s;

                foreach (tsalle s in listeSalle)
                {
                    datagrid_salles.Rows.Add(s.idsalle, s.libsalle, s.prixsalle, s.perssalle);
                }

                var listeReservations = from r in context.treservs
                                        select r;

                foreach (treserv s in listeReservations)
                {
                    datagrid_reservations.Rows.Add(s.idreserv, s.idLigue, s.idsalle, s.datereserv);
                }

                var listeLigues = from r in context.tligues
                                  select r;

                foreach (tligue s in listeLigues)
                {
                    datagrid_ligues.Rows.Add(s.idligue, s.nomligue, s.adrligue, s.villeligue, s.cpligue, s.telligue, s.mailligue, s.intitligue);
                }
                /* WIP */
            }
        }
        private void tab_salles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshContent();
        }
        private void datagrid_salles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            menuLivre.Show();
            Console.WriteLine("SALUT");
        }

        private void Affichage_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void catégorieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new addCateg();
            form.ShowDialog(); 
        }

        private void salleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new addSalle();
            form.ShowDialog(); 
        }

        private void ligueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form form = new addLigue();
            form.ShowDialog(); 
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new about();
            f.ShowDialog();
        }

        private void déconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Login();
            f.ShowDialog();
        }

        private void catégorieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new modifyCat();
            f.ShowDialog();
        }

        private void salleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new modifySalle();
            f.ShowDialog();
        }

        private void ligueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new modifyLigue();
            f.ShowDialog();
        }

        private void compteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new modifyCompte();
            f.ShowDialog();
        }
    }
}
