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
    public partial class FournisseurVue : Form
    {
        private Model model = Model.Instance();
        public FournisseurVue()
        {
            InitializeComponent();            
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

        public ListBox ListBox2
        {
            get
            {
                return listBox2;
            }

            set
            {
                listBox2 = value;
            }
        }

        public Label VarieteArticle
        {
            get
            {
                return varieteArticle;
            }

            set
            {
                varieteArticle = value;
            }
        }
        public Label PrixArticle
        {
            get
            {
                return prixArticle;
            }

            set
            {
                prixArticle = value;
            }
        }
        public Label DesignArticle
        {
            get
            {
                return designationArticle;
            }

            set
            {
                designationArticle = value;
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
                this.model.clearInfoArticle();
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
        private void listBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                this.model.infoArticle(listBox2.SelectedItem.ToString());
            }
        }

        private void listBox2_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    {
                        // act on up arrow
                        if (listBox2.SelectedItem != null)
                        {
                            this.model.infoArticle(listBox2.SelectedItem.ToString());
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        // act on down arrow
                        if (listBox2.SelectedItem != null)
                        {
                            this.model.infoArticle(listBox2.SelectedItem.ToString());
                        }
                        break;
                    }
            }
        }
        public void update()
        {
            this.model.updateFournVue();
        }

    }
}
