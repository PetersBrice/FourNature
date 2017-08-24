using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao.metier
{
    class Devis_articles
    {
        private String devis;
        private String article;    

        public Devis_articles()
        {

        }
        public Devis_articles(String devis, String article)
        {
            this.devis = devis;
            this.article = article;

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
    }
}
