using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourNature.model.dao;
using FourNature.model.metier;
using FourNature.vue;
using FourNature.model.dao.metier;
using System.Windows.Forms;

namespace FourNature.model
{
    class Model
    {
        private DAO<Fournisseur> fournisseurDAO;
        private DAO<Article> articleDAO;
        private DAO<Clients> clientsDAO;
        private FournisseurVue fournVue;
        private ClientVue clientVue;
        private static Model instance;
        private Model()
        {

        }


        public static Model Instance()
        {

            if (instance == null)
            {
                instance = new Model();
            }

            return instance;

        }



        public void Initialize()
        {
            this.fournisseurDAO = new FournisseurDAO();
            this.articleDAO = new ArticleDAO();
            this.clientsDAO = new ClientsDAO();
        }

        public void getFournisseurVue()
        {
            this.fournVue = new FournisseurVue();
            listeFourn();
        }



        public void infoFourn(String fourn)
        {
            //infos fournisseurs
            Fournisseur fournisseur = fournisseurDAO.select(fourn);
            //MessageBox.Show(fournisseur.Adresse1 + "  " + fournisseur.Adresse2 + "  " + fournisseur.Adresse3);
            fournVue.AdresseFournisseur.Text = fournisseur.Adresse1+"  "+fournisseur.Adresse2+"  "+fournisseur.Adresse3;
            fournVue.VilleFournisseur.Text = fournisseur.Ville;
            fournVue.CodePostalFournisseur.Text = fournisseur.Code_post;
            fournVue.NumeroFournisseur.Text = fournisseur.Telephone;
            fournVue.EmailFournisseur.Text = fournisseur.E_mail;

            //articles associés
            fournVue.ListBox2.Items.Clear();
            List<Article> listArticleFourn = articleDAO.selectAvecParam(fourn);
            foreach (Article article in listArticleFourn)
            {
                fournVue.ListBox2.Items.Add(article.Nom_article);
            }


        }    
        
        public void infoArticle(String art)
        {
            //infos articles
            Article article = articleDAO.select(art);
            //MessageBox.Show(article.Observat);
            fournVue.DesignArticle.Text = article.Design;
            fournVue.PrixArticle.Text = article.Prix_achat.ToString();
            fournVue.VarieteArticle.Text = article.Variete;
            
        }  

        public void listeFourn()
        {
            List<Fournisseur> listFournisseur = fournisseurDAO.selectAll();
            foreach (Fournisseur fournisseur in listFournisseur)
            {
                fournVue.ListBoxFournisseur.Items.Add(fournisseur.Fourn);
            }


        }

      

        public FournisseurVue FournVue
        {
            get
            {
                return fournVue;
            }

            set
            {
                fournVue = value;
            }
        }

        public void supprFourn(string fourn)
        {
            fournisseurDAO.delete(fourn);            
        }

        public void supprArticle(string article)
        {
            articleDAO.delete(article);
        }

        public void clearInfoFourn()
        {
            fournVue.AdresseFournisseur.Text = "-";
            fournVue.VilleFournisseur.Text = "-";
            fournVue.CodePostalFournisseur.Text = "-";
            fournVue.NumeroFournisseur.Text = "-";
            fournVue.EmailFournisseur.Text = "-";
        }

        public void clearArticle()
        {
            fournVue.ListBox2.Items.Clear();
        }

        public void clearInfoArticle()
        {
            fournVue.DesignArticle.Text = "-";
            fournVue.PrixArticle.Text = "-";
            fournVue.VarieteArticle.Text = "-";
        }

        public void updateFournVue()
        {
            fournVue.ListBoxFournisseur.Items.Clear();
            listeFourn();
            clearInfoFourn();
            clearArticle();
            clearInfoArticle();

        }

        public void getClientsVue()
        {
            this.clientVue = new ClientVue();
            listeCli();
        }

        public void infoCli(String cli)
        {
            //infos clients
            Clients clients = clientsDAO.select(cli);
            clientVue.AdresseClient.Text = clients.Adresse_1 + "  " + clients.Adresse_2 + "  " + clients.Adresse_3;
            clientVue.VilleClient.Text = clients.Ville;
            clientVue.CodePostalClient.Text = clients.Code_postal;
            clientVue.NumérosClient.Text = clients.Telephone;
            clientVue.EmailClient.Text = clients.E_mail;

            //articles associés
          


        }

        public void listeCli()
        {
            List<Clients> listClients = clientsDAO.selectAll();
            foreach (Clients clients in listClients)
            {
               clientVue.ListClient.Items.Add(clients.Client);
            }


        }



        public ClientVue ClientVue
        {
            get
            {
                return clientVue;
            }

            set
            {
                clientVue = value;
            }
        }

        public void supprClient(string cli)
        {
            clientsDAO.delete(cli);
        }

        public void clearInfoCli()
        {
            clientVue.AdresseClient.Text = "-";
            clientVue.VilleClient.Text = "-";
            clientVue.CodePostalClient.Text = "-";
            clientVue.NumérosClient.Text = "-";
            clientVue.EmailClient.Text = "-";
        }

   
        internal void updateClientVue()
        {
            clientVue.ListClient.Items.Clear();
            listeCli();
            clearInfoCli(); 

        }
    }
}
