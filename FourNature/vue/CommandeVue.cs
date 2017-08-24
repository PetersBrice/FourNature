using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature.vue
{
    public partial class CommandeVue : Form
    {
        public CommandeVue()
        {
            InitializeComponent();
        }

        private void Commande_Load(object sender, EventArgs e)
        {
            listViewCommande.View = View.Details;
            listViewCommande.Columns.Add("Article");
            listViewCommande.Columns.Add("Designation");
            listViewCommande.Columns.Add("Fournisseur");
            listViewCommande.Columns.Add("Quantité");
            listViewCommande.Columns.Add("Prix");
            listViewCommande.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCommande.Columns[3].Width = 52;
            listViewCommande.Columns[3].TextAlign = HorizontalAlignment.Center;
            listViewCommande.Columns[4].TextAlign = HorizontalAlignment.Center;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public Label LabelPrix
        {
            get
            {
                return labelPrix;
            }

            set
            {
                labelPrix = value;
            }
        }

        public Label LabelNcde
        {
            get
            {
                return labelNcde;
            }

            set
            {
                labelNcde = value;
            }
        }

        public ListView ListViewCommande
        {
            get
            {
                return listViewCommande;
            }

            set
            {
                listViewCommande = value;
            }
        }

        

        

        private void listBoxFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPrix_Click(object sender, EventArgs e)
        {

        }

        private void labelNcde_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
