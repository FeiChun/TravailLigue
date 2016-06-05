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
    public partial class addCompte : Form
    {
        public addCompte()
        {
            InitializeComponent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                tcompte compte = new tcompte();
                // fields to be insert
                int num = (from tcompte in context.tcomptes
                             select tcompte.idCompte).Max();
                num += 1;
                compte.idCompte = num;
                compte.identifiant = tb_id.Text;
                compte.password = tb_mdp.Text;
                context.tcomptes.Add(compte);
                // executes the commands to implement the changes to the database
                context.SaveChanges();

                this.Close();
            }
        }

        private void btn_annul_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
