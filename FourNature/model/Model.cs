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
        private DAO<Commandes_articles> commandeDAO;
        private DAO<Article> articleDAO;
        private DAO<Clients> clientsDAO;
        private DAO<Tarifs_articles> tarifs_articlesDAO;
        private FournisseurVue fournVue;
        private CommandeVue commandeVue;
        private ClientVue clientVue;
        public Model()
        {
            this.fournisseurDAO = new FournisseurDAO();
            this.articleDAO = new ArticleDAO();
            this.commandeDAO = new Commandes_articlesDAO();
            this.clientsDAO = new ClientsDAO();
            this.tarifs_articlesDAO = new Tarifs_articlesDAO();
            this.fournVue = new FournisseurVue(this);
            this.clientVue = new ClientVue(this);
            this.commandeVue = new CommandeVue(this);
            listeCli();
            
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //                                                  Partie Vue Fournisseurs
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------

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

        public void updateFournVue()
        {
            fournVue.ListBoxFournisseur.Items.Clear();
            listeFourn();
            clearInfoFourn();
            clearArticle();

        }
        public void clearInfoFourn()
        {
            fournVue.AdresseFournisseur.Text = "-";
            fournVue.VilleFournisseur.Text = "-";
            fournVue.CodePostalFournisseur.Text = "-";
            fournVue.NumeroFournisseur.Text = "-";
            fournVue.EmailFournisseur.Text = "-";
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //                                                  Partie Vue Fournisseurs
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        public void supprArticle(string article)
        {
            articleDAO.delete(article);
        }
        public void clearArticle()
        {
            fournVue.ListBox2.Items.Clear();
        }        
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //                                                  Partie Vue Clients
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
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
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //                                                  Partie Vue Commandes
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------------------------------
        public List<Commandes_articles> infoCommande(String ncde)
        {
            //infos articles
            List<Commandes_articles> listCommande = commandeDAO.selectAvecParam(ncde);            
            return listCommande;
        }

        public float CalculPrixTotal(List<Commandes_articles> l)
        {
            float montant = 0;
            foreach (Commandes_articles commande in l)
            {
                montant += commande.Prix_achat*commande.Qte_cde;          
            }

            return montant;
        }

        public CommandeVue CommandeVue
        {
            get
            {
                return commandeVue;
            }

            set
            {
                commandeVue = value;
            }
        }

        public void maj_Commande(Commandes_articles cmd)
        {
            commandeDAO.update(cmd);
        }

        public List<Tarifs_articles> getFournArticle(String text)
        {            
            List<Tarifs_articles> listArticle = tarifs_articlesDAO.selectAvecParam(text);
            return listArticle;            
        }
        public void prompt()
        {
            Prompt prompt = new Prompt(this);
            //MessageBox.Show(listViewCommande.SelectedItems.Count.ToString());
            prompt.ShowDialog(commandeVue.ListViewCommande.SelectedItems[0].Text, "Modification de l'article : " + commandeVue.ListViewCommande.SelectedItems[0].Text, commandeVue.LabelNcde.Text.Substring(14));
        }
    }
}
