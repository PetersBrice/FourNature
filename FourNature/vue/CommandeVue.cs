using FourNature.model;
using FourNature.model.dao.metier;
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
    partial class CommandeVue : Form
    {
        private Model model;
        public CommandeVue(Model model)
        {
            this.model = model;            
            InitializeComponent();
            List<Commandes_articles> listCommande = this.model.infoCommande();
            remplirListView(listCommande);
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


        public void remplirListView(List<Commandes_articles> listCommande)
        {
            this.labelNcde.Text = "N° Commande : " + listCommande[1].Ncde;
            this.labelPrix.Text = "Prix Total : " + model.CalculPrixTotal(listCommande) + " €";
            foreach (Commandes_articles commande in listCommande)
            {
                //MessageBox.Show(commande.Design);
                ListViewItem listItem = new ListViewItem();
                listItem.Text = commande.Article;
                listItem.SubItems.Add(commande.Design);
                listItem.SubItems.Add(commande.Fourn);
                listItem.SubItems.Add(commande.Qte_cde.ToString());
                listItem.SubItems.Add(commande.Prix_achat.ToString() + " €");
                listViewCommande.Items.Add(listItem);
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

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (listViewCommande.SelectedItems.Count > 0)
            {
                model.prompt();
                update();              
            }
        }

        public void update()
        {
            this.listViewCommande.Items.Clear();
            remplirListView(model.infoCommande());
        }

        private void clientToolStripMenuItemOuvrir_Click(object sender, EventArgs e)
        {
            
            model.ClientVue.Show();
            model.CommandeVue.Hide();
            model.updateClientVue();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.FournVue.Show();
            model.CommandeVue.Hide();
            model.updateFournVue();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
    }
}
