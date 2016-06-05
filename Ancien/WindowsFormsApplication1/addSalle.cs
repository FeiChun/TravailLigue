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
    public partial class addSalle : Form
    {
        public addSalle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                tsalle salle = new tsalle();
                // fields to be insert
                short num = (from tsalle in context.tsalles
                           select tsalle.idsalle).Max();
                num += 1;
                salle.idsalle = num;
                salle.libsalle = tb_lib.Text;
                salle.prixsalle = decimal.Parse(tb_px.Text);
                salle.perssalle = short.Parse(tb_pers.Text);
                context.tsalles.Add(salle);
                // executes the commands to implement the changes to the database
                context.SaveChanges();

                this.Close();
            }
        }

        private void lstCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var results = from s in context.tcategories
                              select s;
                
            }
        }
    }
}
