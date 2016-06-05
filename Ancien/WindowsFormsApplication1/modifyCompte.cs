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
    public partial class modifyCompte : Form
    {
        public modifyCompte()
        {
            InitializeComponent();
        }

        private void CompteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            short selectedItem1 = short.Parse(CompteBox.Items[CompteBox.SelectedIndex].ToString());

            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var listeCompte = from s in context.tcomptes
                                 where s.idCompte == selectedItem1
                                 select s;
                foreach (tcompte s in listeCompte)
                {
                    string selectedItem = s.identifiant;
                    IDBox.Text = selectedItem;

                    string selectedItem2 = s.password;
                    MDPBox.Text = selectedItem2;
                }

            }
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                short selectedItem1 = short.Parse(CompteBox.Items[CompteBox.SelectedIndex].ToString());
                var Categ = (from s in context.tcomptes
                             where s.idCompte == selectedItem1
                             select s).First();
                Categ.identifiant = IDBox.Text;
                Categ.password = MDPBox.Text;


                // executes the commands to implement the changes to the database
                context.SaveChanges();
            }
            RefreshContent();
        }

        private void modifyCompte_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }
        private void RefreshContent()
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                CompteBox.Items.Clear();
                var listeCompte = from s in context.tcomptes
                                 select s;
                foreach (tcompte s in listeCompte)
                {
                    CompteBox.Items.Add(s.idCompte);
                }

            }
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
