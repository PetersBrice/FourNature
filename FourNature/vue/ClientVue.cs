using FourNature.model;
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
    public partial class ClientVue : Form
    {
        private Model model = Model.Instance();
        private ToolStripMenuItem clientToolStripMenuItemOuvrirt;

        public ClientVue()
        {
            InitializeComponent();
        }
        //adresseClient villeClient codePostalClient numérosClient emailClient

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

        public ListBox ArcticleClientListBox
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
            model.getFournisseurVue();
            ShowDialog(model.FournVue);
        }
    }
}
