using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Tarifs_articles
    {
        private String fourn;
        private String article;
        private float prix_achat; 

        public Tarifs_articles()
        {

        }
        public Tarifs_articles(String fourn, String article, float prix_achat)
        {
            this.fourn = fourn;
            this.article = article;
            this.prix_achat = prix_achat;
        }

        public string Article
        {
            get
            {
                return article;
            }

            set
            {
                article = value;
            }
        }
        public string Fourn
        {
            get
            {
                return fourn;
            }

            set
            {
                fourn = value;
            }
        }
        public float Prix_achat
        {
            get
            {
                return prix_achat;
            }

            set
            {
                prix_achat = value;
            }
        }
    }
}
