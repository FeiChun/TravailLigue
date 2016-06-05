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
    public partial class addLigue : Form
    {
        public addLigue()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                tligue ligue = new tligue();
                // fields to be insert
                int num = (from tligue in context.tligues
                             select tligue.idligue).Max();
                num += 1;
                ligue.idligue = num;
                ligue.nomligue = tb_name.Text;
                ligue.adrligue = tb_ad.Text;
                ligue.villeligue = tb_ville.Text;
                ligue.cpligue = tb_cp.Text;
                ligue.telligue = tb_tel.Text;
                ligue.mailligue = tb_mail.Text;
                ligue.intitligue = tb_intit.Text;
                context.tligues.Add(ligue);
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
