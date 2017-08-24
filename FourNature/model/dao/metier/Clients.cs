using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Clients
    {
        private String client;
        private String adresse_1;
        private String adresse_2;
        private String adresse_3;
        private String ville;
        private String code_postale;
        private String e_mail;
        private String telephone;
        private String telephone1;
        private String telephone2;

        public Clients()
        {

        }

        public Clients(String new_client)
        {
            client = new_client;
        }
        public Clients(String new_client, String new_adresse_1,String new_adresse_2,String new_adresse_3,String new_ville,
            String new_code_postale,String new_e_mail,String new_telephone,String new_telephone1,String new_telephone2)
        {
            client = new_client;
            adresse_1 = new_adresse_1;
            adresse_2 = new_adresse_2;
            adresse_3 = new_adresse_3;
            ville = new_ville;
            code_postale = new_code_postale;
            e_mail = new_e_mail;
            telephone = new_telephone;
            telephone1 = new_telephone1;
            telephone2 = new_telephone2;
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

        public string Code_postal
        {
            get
            {
                return code_postale;
            }

            set
            {
                code_postale = value;
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

        public string Telephone2
        {
            get
            {
                return telephone2;
            }

            set
            {
                telephone2 = value;
            }
        }



    }
}
