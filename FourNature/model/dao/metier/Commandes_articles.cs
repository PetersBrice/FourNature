using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Commandes_articles
    {
        private String ncde;
        private String article;
        private String design;
        private String fourn;
        private String famille;
        private String lot;
        private String notes;
        private float prix_achat;
        private float qte_cde;
        private float prix_unit;
        

        public Commandes_articles()
        {

        }

        public Commandes_articles(String ncde)
        {
            this.ncde = ncde;
        }

        public Commandes_articles(String ncde, String fourn, String article,  float prix)
        {
            this.ncde = ncde;
            this.article = article;
            this.fourn = fourn;
            this.prix_achat = prix;
        }

        public Commandes_articles(String ncde, String article, String design, String fourn, String famille, String lot, String notes, float prix_achat,
                           float qte_cde, float prix_unit)
        {
            this.ncde = ncde;
            this.article = article;
            this.design = design;
            this.fourn = fourn;
            this.famille = famille;
            this.lot = lot;
            this.notes = notes;
            this.prix_achat = prix_achat;
            this.qte_cde = qte_cde;
            this.prix_unit = prix_unit;
        }

        public string Ncde
        {
            get
            {
                return ncde;
            }

            set
            {
                ncde = value;
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

        public string Famille
        {
            get
            {
                return famille;
            }

            set
            {
                famille = value;
            }
        }

        public string Design
        {
            get
            {
                return design;
            }

            set
            {
                design = value;
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

        public float Prix_unit
        {
            get
            {
                return prix_unit;
            }

            set
            {
                prix_unit = value;
            }
        }

        public string Lot
        {
            get
            {
                return lot;
            }

            set
            {
                lot = value;
            }
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

        public float Qte_cde
        {
            get
            {
                return qte_cde;
            }

            set
            {
                qte_cde = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }

            set
            {
                notes = value;
            }
        }
    }
}
