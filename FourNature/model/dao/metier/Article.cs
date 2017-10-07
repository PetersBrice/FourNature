using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Article
    {
        private String nom_article;
        private String fourn;
        private String design;
        private String famille;
        private String variete;
        private String observat;
        private String notes;
        private float prix_achat;
        private float prix_ttc;
        private float prix_unit;
        private String taille;
        private String photo;


        public Article()
        {

        }
        public Article(String nom_article)
        {
            this.nom_article = nom_article;
        }
        public Article(String nom_article, String design, String famille, String variete,float prix_achat,String taille)
        {
            this.nom_article = nom_article;
            this.design = design;
            this.famille = famille;
            this.variete = variete;
            this.prix_achat = prix_achat;
            this.taille = taille;
        }

        public Article(String nom_article, String fourn, String design, String famille, String variete, String observat, String notes, float prix_achat,
                              float prix_ttc, float prix_unit, String taille, String photo)
        {
            this.nom_article = nom_article;
            this.fourn = fourn;
            this.design = design;
            this.famille = famille;
            this.variete = variete;
            this.observat = observat;
            this.notes = notes;
            this.prix_achat = prix_achat;
            this.prix_ttc = prix_ttc;
            this.prix_unit = prix_unit;
            this.taille = taille;
            this.photo = photo;
        }

        public string Nom_article
        {
            get
            {
                return nom_article;
            }

            set
            {
                nom_article = value;
            }
        }

        public string Four
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
        public string Variete
        {
            get
            {
                return variete;
            }

            set
            {
                variete = value;
            }
        }
        public string Observat
        {
            get
            {
                return observat;
            }

            set
            {
                observat = value;
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
        public float Prix_ttc
        {
            get
            {
                return prix_ttc;
            }

            set
            {
                prix_ttc = value;
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
        public String Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
        public string Taille
        {
            get
            {
                return taille;
            }

            set
            {
                taille = value;
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

    }


}
