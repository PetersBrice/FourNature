using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourNature.model.dao;
using FourNature.model.metier;


namespace FourNature.model.dao
{
    class DAOFactory
    {
        public static DAO<Fournisseur> getFournisseurDAO() { return new FournisseurDAO(); }
    }
}
