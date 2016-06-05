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
    public partial class modifyLigue : Form
    {
        public modifyLigue()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                short selectedItem1 = short.Parse(listBox1.Items[listBox1.SelectedIndex].ToString());
                var Categ = (from s in context.tligues
                             where s.idligue == selectedItem1
                             select s).First();
                Categ.nomligue = NomBox.Text;
                Categ.adrligue = AdrBox.Text;
                Categ.villeligue = VilleBox.Text;
                Categ.cpligue = CPBox.Text;
                Categ.telligue = TelBox.Text;
                Categ.mailligue = MailBox.Text;
                Categ.intitligue = IntBox.Text;


                // executes the commands to implement the changes to the database
                context.SaveChanges();
            }
            RefreshContent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            short selectedItem1 = short.Parse(listBox1.Items[listBox1.SelectedIndex].ToString());

            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                var listeligue = from s in context.tligues
                                 where s.idligue == selectedItem1
                                 select s;
                foreach (tligue s in listeligue)
                {
                    string selectedItem = s.nomligue;
                    NomBox.Text = selectedItem;

                    string selectedItem2 = s.adrligue;
                    AdrBox.Text = selectedItem2;

                    string selectedItem3 = s.villeligue;
                    VilleBox.Text = selectedItem3;

                    string selectedItem4 = s.cpligue;
                    CPBox.Text = selectedItem4;

                    string selectedItem5 = s.telligue;
                    TelBox.Text = selectedItem5;

                    string selectedItem6 = s.mailligue;
                    MailBox.Text = selectedItem6;

                    string selectedItem7 = s.intitligue;
                    IntBox.Text = selectedItem7;
                }
                
            }
        }

        private void modifyLigue_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }
        private void RefreshContent()
        {
            using (TravailLigueEntities context = new TravailLigueEntities())
            {
                listBox1.Items.Clear();
                var listeligue = from s in context.tligues
                                 select s;
                foreach (tligue s in listeligue)
                {
                    listBox1.Items.Add(s.idligue);
                }

            }
        }

        private void btn_an_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}