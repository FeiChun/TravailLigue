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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var results = from s in context.tcomptes
                              where s.identifiant.Equals(tb_id.Text)
                              where s.password.Equals(tb_mdp.Text)
                              select s;
            

                if (results.Count() > 0)
                {
                    this.Hide();
                    Form mainForm = new Affichage();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erreur authentification !", "L'identifiant/mot de passe est incorrect !", MessageBoxButtons.RetryCancel);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_id.Clear();
            tb_mdp.Clear(); 
        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newcpt_Click(object sender, EventArgs e)
        {
            Form addCompte = new addCompte();
            addCompte.ShowDialog(); 
        }
    }
}
