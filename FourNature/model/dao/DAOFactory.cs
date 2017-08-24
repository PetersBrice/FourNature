using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourNature.model.dao;
using FourNature.model.metier;
using FourNature.model.dao.metier;

namespace FourNature.model.dao
{
    class DAOFactory
    {
        public static DAO<Fournisseur> getFournisseurDAO() { return new FournisseurDAO(); }
        public static DAO<Article> getArticleDAO() { return new ArticleDAO(); }
        public static DAO<Clients> getClientsDAO() { return new ClientsDAO(); }
        public static DAO<Devis_entetes> getDevis_entetesDAO() { return new Devis_entetesDAO(); }
    }
}
