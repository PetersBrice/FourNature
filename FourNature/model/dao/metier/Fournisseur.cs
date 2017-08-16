using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.metier
{
    class Fournisseur
    {
        private String adresse1;
        private String adresse2;
        private String adresse3;
        private String code_post;
        private String comment;
        private String e_mail;
        private String fax;
        private String fourn;
        private String mots_clefs;
        private String nom;
        private String nom_cor;
        private String pays;
        private String regl;
        private String telephone;
        private String telephone1;
        private String titre;
        private String type_fournisseur;
        private String ville;
        private String www;
        private int mt_franco;

        public Fournisseur()
        {

        }

        public Fournisseur(String fourn)
        {
            this.fourn = fourn;
        }

        public Fournisseur(String adresse1, String adresse2, String adresse3, String code_post, String comment, String e_mail, String fax, String fourn,
                           String mots_clefs, String nom, String nom_cor, String pays, String regl, String telephone, String telephone1, String titre,
                           String type_fournisseur, String ville, String www, int mt_franco)
        {
            this.adresse1 = adresse1;
            this.adresse2 = adresse2;
            this.adresse3 = adresse3;
            this.code_post = code_post;
            this.comment = comment;
            this.e_mail = e_mail;
            this.fax = fax;
            this.fourn = fourn;
            this.mots_clefs = mots_clefs;
            this.nom = nom;
            this.nom_cor = nom_cor;
            this.pays = pays;
            this.regl = regl;
            this.telephone = telephone;
            this.telephone1 = telephone1;
            this.titre = titre;
            this.type_fournisseur = type_fournisseur;
            this.ville = ville;
            this.www = www;
            this.mt_franco = mt_franco;
        }

        public string Adresse1
        {
            get
            {
                return adresse1;
            }

            set
            {
                adresse1 = value;
            }
        }

        public string Adresse2
        {
            get
            {
                return adresse2;
            }

            set
            {
                adresse2 = value;
            }
        }

        public string Adresse3
        {
            get
            {
                return adresse3;
            }

            set
            {
                adresse3 = value;
            }
        }

        public string Code_post
        {
            get
            {
                return code_post;
            }

            set
            {
                code_post = value;
            }
        }

        public string E_mail
        {
            get
            {
                return e_mail;
            }

            set
            {
                e_mail = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
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

        public string Mots_clefs
        {
            get
            {
                return mots_clefs;
            }

            set
            {
                mots_clefs = value;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Nom_cor
        {
            get
            {
                return nom_cor;
            }

            set
            {
                nom_cor = value;
            }
        }

        public string Pays
        {
            get
            {
                return pays;
            }

            set
            {
                pays = value;
            }
        }

        public string Regl
        {
            get
            {
                return regl;
            }

            set
            {
                regl = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Telephone1
        {
            get
            {
                return telephone1;
            }

            set
            {
                telephone1 = value;
            }
        }

        public string Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
            }
        }

        public int Mt_franco
        {
            get
            {
                return mt_franco;
            }

            set
            {
                mt_franco = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        public string Www
        {
            get
            {
                return www;
            }

            set
            {
                www = value;
            }
        }
    }
}
