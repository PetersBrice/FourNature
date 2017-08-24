using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Devis_entetes
    {
        private String devis;
        private String adresse_1;
        private String adresse_2;
        private String adresse_3;
        private String client;

        public Devis_entetes()
        {

        }
        public Devis_entetes(String devis,String client, String adresse_1, String adresse_2, String adresse_3)
        {
            this.devis = devis;
            this.adresse_1 = adresse_1;
            this.adresse_2 = adresse_2;
            this.adresse_3 = adresse_3;
            this.client = client;

        }

        public string Devis
        {
            get
            {
                return devis;
            }

            set
            {
                devis = value;
            }
        }
        public string Adresse_1
        {
            get
            {
                return adresse_1;
            }

            set
            {
                adresse_1 = value;
            }
        }
        public string Adresse_2
        {
            get
            {
                return adresse_2;
            }

            set
            {
                adresse_2 = value;
            }
        }
        public string Adresse_3
        {
            get
            {
                return adresse_3;
            }

            set
            {
                adresse_3 = value;
            }
        }
        public string Client
        {
            get
            {
                return client;
            }

            set
            {
                client = value;
            }
        }
    }
}
