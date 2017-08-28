using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao
{
    class Tarifs_articlesDAO : DAO<Tarifs_articles>
    {
        public override bool create(Tarifs_articles obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            throw new NotImplementedException();
        }

        public override Tarifs_articles select(string s)
        {
            throw new NotImplementedException();
        }

        public override List<Tarifs_articles> selectAll()
        {
            throw new NotImplementedException();
        }

        public override List<Tarifs_articles> selectAvecParam(string s)
        {
            connect();
            List<Tarifs_articles> listArticle = new List<Tarifs_articles>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM Tarifs_articles WHERE article ='" + s + "'", _connection))
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
                                listArticle.Add(new Tarifs_articles(reader["fourn"].ToString(), reader["article"].ToString(), float.Parse(reader["prix_achat"].ToString())));
                            }
                        }
                    }
                }
            }
            return listArticle;
        }

        public override bool update(Tarifs_articles obj)
        {
            throw new NotImplementedException();
        }
    }
}
