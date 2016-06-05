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
    public partial class addCateg : Form
    {
        public addCateg()
        {
            InitializeComponent();
        }

        private void btn_val_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                tcategory categ = new tcategory();
                // fields to be insert
                short num = (from tcategory in context.tcategories
                             select tcategory.idCat).Max();
                num += 1;
                categ.idCat = num;          
                categ.libcat = tb_libcat.Text;
                context.tcategories.Add(categ);
                // executes the commands to implement the changes to the database
                context.SaveChanges();

                this.Close();
            }
        }

        private void btn_supr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
