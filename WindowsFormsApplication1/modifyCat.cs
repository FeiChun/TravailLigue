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
    public partial class modifyCat : Form
    {
        public modifyCat()
        {
            InitializeComponent();
        }

        private void btn_ancat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            short selectedItem1 = short.Parse(listBox1.Items[listBox1.SelectedIndex].ToString());

             using (TravailLigueEntities context = new TravailLigueEntities())
             {
                 var listeCat = from s in context.tcategories
                                where s.idCat == selectedItem1
                                select s;
                 foreach (tcategory s in listeCat)
                 {
                    string selectedItem = s.libcat ;
                    textBox1.Text = selectedItem;
                 }

             }
        }
        private void RefreshContent()
        {
            listBox1.Items.Clear();
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var listeCat = from s in context.tcategories
                               select s;
                foreach (tcategory s in listeCat)
                {
                    listBox1.Items.Add(s.idCat);
                }

            }
        }
        private void modifyCat_Load(object sender, EventArgs e)
        {

            RefreshContent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_valcat_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                short selectedItem1 = short.Parse(listBox1.Items[listBox1.SelectedIndex].ToString());
                var Categ = (from s in context.tcategories
                               where s.idCat == selectedItem1
                               select s).First();
                Categ.libcat= textBox1.Text;
                
                // executes the commands to implement the changes to the database
                context.SaveChanges();
            }
            RefreshContent();
        }

        public short selectedItem1 { get; set; }
    }
}
