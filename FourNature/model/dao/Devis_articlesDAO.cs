using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao
{
    class Devis_articlesDAO : DAO<Devis_articles>
    {
        public override bool create(Devis_articles obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            throw new NotImplementedException();
        }

        public override Devis_articles select(string s)
        {
            throw new NotImplementedException();
        }

        public override List<Devis_articles> selectAll()
        {
            throw new NotImplementedException();
        }

        public override List<Devis_articles> selectAvecParam(string s)
        {
            connect();
            List<Devis_articles> listDevis = new List<Devis_articles>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM devis_articles WHERE devis ='" + s + "'", _connection))
                    {

                        // Execution de la requette et lecture du résultat en mode connecté
                        OleDbDataReader reader = _cmd.ExecuteReader();

                        //Console.WriteLine("Request created.");
                        //Si le résultat comporte des lignes
                        if (reader.HasRows)
                        {
                            //reader.Read() passe à la ligne suivante et renvoi false à la fin du DataReader
                            while (reader.Read())
                            {
                                 listDevis.Add(new Devis_articles(reader["devis"].ToString(), reader["article"].ToString()));
                            }
                        }
                    }
                }
            }
            return listDevis;
        }

        public override bool update(Devis_articles obj)
        {
            throw new NotImplementedException();
        }
    }
}
