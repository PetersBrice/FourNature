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
    partial class FournisseurVue : Form
    {
        private Model model;
        public FournisseurVue(Model model)
        {
            this.model = model;            
            InitializeComponent();
            Article_Load();
        }

        public Label AdresseFournisseur
        {
            get
            {
                return adresseFournisseur;
            }

            set
            {
                adresseFournisseur = value;
            }
        }
        public Label VilleFournisseur
        {
            get
            {
                return villeFournisseur;
            }

            set
            {
                villeFournisseur = value;
            }
        }
        public Label CodePostalFournisseur
        {
            get
            {
                return codePostalFournisseur;
            }

            set
            {
                codePostalFournisseur = value;
            }
        }
        public Label NumeroFournisseur
        {
            get
            {
                return numeroFournisseur;
            }

            set
            {
                numeroFournisseur = value;
            }
        }
        public Label EmailFournisseur
        {
            get
            {
                return emailFournisseur;
            }

            set
            {
                emailFournisseur = value;
            }
        }

        public ListBox ListBoxFournisseur
        {
            get
            {
                return listBoxFournisseur;
            }

            set
            {
                listBoxFournisseur = value;
            }
        }

        public ListView ListViewArticle
        {
            get
            {
                return listViewArticle;
            }

            set
            {
                listViewArticle = value;
            }
        }

       
     
    

        private void Fourniture_Load(object sender, EventArgs e)
        { }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void AjouterFournisseur_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------
        //Liste Box Fournisseur
        //-----------------------------------------------------
        private void listBoxFournisseur_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxFournisseur.SelectedItem != null)
            {
                this.model.infoFourn(listBoxFournisseur.SelectedItem.ToString());                
            }
        }
      


        private void SupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (listBoxFournisseur.SelectedItem != null)
            {
                if (MessageBox.Show(this, "Etes-vous sûr de vouloir supprimer " + listBoxFournisseur.SelectedItem.ToString() + " ?", " ATTENTION !!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.model.supprFourn(listBoxFournisseur.SelectedItem.ToString());
                }
            }
            update();
        }


        private void listBoxFournisseur_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        // act on up arrow
                        if (listBoxFournisseur.SelectedItem != null)
                        {
                            this.model.infoFourn(listBoxFournisseur.SelectedItem.ToString());
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        // act on down arrow
                        if (listBoxFournisseur.SelectedItem != null)
                        {
                            this.model.infoFourn(listBoxFournisseur.SelectedItem.ToString());
                        }
                        break;
                    }
            }
        }
        //--------------------------------------------------------
        //--------------------------------------------------------
        //listbox2
        //--------------------------------------------------------
       


        public void update()
        {
            this.model.updateFournVue();
        }

        private void SupprimerArticle_Click(object sender, EventArgs e)
        {
            if (listViewArticle.SelectedItems[0] != null)
            {
                if (MessageBox.Show(this, "Etes-vous sûr de vouloir supprimer " + listViewArticle.SelectedItems[0].ToString() + " ?", " ATTENTION !!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    this.model.supprArticle(listViewArticle.SelectedItems[0].ToString());
                }
            }
            update();
        }

        private void clientToolStripMenuItemOuvrir_Click(object sender, EventArgs e)
        {
            model.ClientVue.Show();
            model.FournVue.Hide();
            model.updateClientVue();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.CommandeVue.Show();
            model.FournVue.Hide();
            model.CommandeVue.update();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Article_Load()
        {
            listViewArticle.View = View.Details;
            listViewArticle.Columns.Add("Article");
            listViewArticle.Columns.Add("Designation");
            listViewArticle.Columns.Add("Prix");
            listViewArticle.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewArticle.Columns[0].Width = 100;
            listViewArticle.Columns[1].Width = 100;
            listViewArticle.Columns[2].Width = 100;

        }

        public void remplirListView(List<Article> listCommande)
        {
           
            foreach (Article article in listCommande)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = article.Nom_article;
                listItem.SubItems.Add(article.Design);
                listItem.SubItems.Add(article.Prix_achat.ToString() + " €");
                listViewArticle.Items.Add(listItem);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {            
                Environment.Exit(0);
        }
    }
}
