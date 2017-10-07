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
    partial class ClientVue : Form
    {
        private Model model;
        private ToolStripMenuItem clientToolStripMenuItemOuvrirt;

        public ClientVue(Model model)
        {
            this.model = model;
            InitializeComponent();
            Article_Load();
        }


        public Label AdresseClient
        {
            get
            {
                return adresseClient;
            }

            set
            {
                adresseClient = value;
            }
        }

        public Label VilleClient
        {
            get
            {
                return villeClient;
            }

            set
            {
                villeClient = value;
            }
        }

        public Label NumérosClient
        {
            get
            {
                return numérosClient;
            }

            set
            {
                numérosClient = value;
            }
        }

        public Label CodePostalClient
        {
            get
            {
                return codePostalClient;
            }

            set
            {
                codePostalClient = value;
            }
        }

        public Label EmailClient
        {
            get
            {
                return emailClient;
            }

            set
            {
                emailClient = value;
            }
        }

        public ToolStripMenuItem ClientToolStripMenuItemOuvrir
        {
            get
            {
                return clientToolStripMenuItemOuvrir;
            }

            set
            {
                clientToolStripMenuItemOuvrir = value;
            }
        }

        public ListBox ListClient
        {
            get
            {
                return listClient;
            }

            set
            {
                listClient = value;
            }
        }

        public ListView ArcticleClientListBox
        {
            get
            {
                return articleClientListBox;
            }

            set
            {
                articleClientListBox = value;
            }
        }

        private void Article_Load()
        {
            articleClientListBox.View = View.Details;
            articleClientListBox.Columns.Add("Article");
            articleClientListBox.Columns.Add("Designation");
            articleClientListBox.Columns.Add("Fournisseur");
            articleClientListBox.Columns.Add("Quantité");
            articleClientListBox.Columns.Add("Prix");
            //articleClientListBox.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            for (int i = 0; i < 5; i++)
            {
                articleClientListBox.Columns[i].Width = 100;
            }
            //articleClientListBox.Columns[3].Width = 52;
            articleClientListBox.Columns[3].TextAlign = HorizontalAlignment.Center;
            articleClientListBox.Columns[4].TextAlign = HorizontalAlignment.Center;
        }

        public void remplirListView(List<Article> listArticle)
        {
            for (int i = 1; i < listArticle.Count() - 1; i++)
            {
                //MessageBox.Show(commande.Design);
                ListViewItem listItem = new ListViewItem();
                listItem.Text = listArticle[i].Nom_article;
                listItem.SubItems.Add(listArticle[i].Design);
                listItem.SubItems.Add(listArticle[i].Four);
                if (listArticle[i].Taille != null)
                {
                    listItem.SubItems.Add(listArticle[i].Taille.ToString());
                }else
                {
                    listItem.SubItems.Add("0");
                }
                listItem.SubItems.Add(listArticle[i].Prix_achat.ToString() + " €");
                articleClientListBox.Items.Add(listItem);
            }
        }

        private void listClient_MouseClick(object sender, MouseEventArgs e)
        {
            if (listClient.SelectedItem != null)
            {
                //this.model.clearInfoArticle();
                this.model.infoCli(listClient.SelectedItem.ToString());
            }
        }
        private void listClient_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        // act on up arrow
                        if (listClient.SelectedItem != null)
                        {
                            this.model.infoCli(listClient.SelectedItem.ToString());
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        // act on down arrow
                        if (listClient.SelectedItem != null)
                        {
                            this.model.infoCli(listClient.SelectedItem.ToString());
                        }
                        break;
                    }
            }
        }

        public void update()
        {
            this.model.updateClientVue();
            clientToolStripMenuItemOuvrir.Enabled = false;

        }


        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.FournVue.Show();
            model.ClientVue.Hide();
            model.updateFournVue();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            model.CommandeVue.Show();
            model.ClientVue.Hide();
            model.CommandeVue.update();
        }

        private void articleClientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
