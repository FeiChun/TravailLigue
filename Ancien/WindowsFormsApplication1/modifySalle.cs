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
    public partial class modifySalle : Form
    {
        public modifySalle()
        {
            InitializeComponent();
        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_salle_SelectedIndexChanged(object sender, EventArgs e)
        {
            short selectedItem1 = short.Parse(lb_salle.Items[lb_salle.SelectedIndex].ToString());

            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var listesal = from s in context.tsalles
                               where s.idsalle == selectedItem1
                               select s;
                foreach (tsalle s in listesal)
                {
                    string selectedItem = s.libsalle;
                    tb_nsalle.Text = selectedItem;

                    string selectedItem4 = s.prixsalle.ToString();
                    tb_psalle.Text = selectedItem4;

                    string selectedItem2 = s.perssalle.ToString();
                    tb_permax.Text = selectedItem2;

                    string selectedItem3 = s.idCat.ToString();
                    tb_icateg.Text = selectedItem3;
                }

            }
        }
        private void RefreshContent()
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                lb_salle.Items.Clear();
                var listesal = from s in context.tsalles
                               select s;
                foreach (tsalle s in listesal)
                {
                    lb_salle.Items.Add(s.idsalle);
                }

            }
        }
        private void modifySalle_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                short selectedItem1 = short.Parse(lb_salle.Items[lb_salle.SelectedIndex].ToString());
                var Categ = (from s in context.tsalles
                             where s.idsalle == selectedItem1
                             select s).First();
                Categ.libsalle = tb_nsalle.Text;
                Categ.prixsalle = decimal.Parse(tb_psalle.Text);
                Categ.perssalle = short.Parse(tb_permax.Text);
                Categ.idCat = short.Parse(tb_icateg.Text);


                // executes the commands to implement the changes to the database
                context.SaveChanges();
            }
            RefreshContent();
        }
    }
}
