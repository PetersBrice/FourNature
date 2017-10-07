using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature.model.dao
{
    class ArticleDAO : DAO<Article>
    {
        public ArticleDAO():base(){ }

        public override bool create(Article obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("DELETE FROM articles WHERE article = '" + s + "'", _connection))
                {

                    // Execution de la requette et lecture du résultat en mode connecté
                    OleDbDataReader reader = _cmd.ExecuteReader();

                    //Console.WriteLine("Request created.");
                    //Si le résultat comporte des lignes
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Article supprimé avec succès!");

                    }
                    else MessageBox.Show("Erreur!");
                }
            }
        }

        public override Article select(string s)
        {
            Article article = new Article();

            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("SELECT * FROM articles WHERE article = '" + s + "'", _connection))
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
                            article = new Article(reader["article"].ToString(), reader["fourn"].ToString(), reader["design"].ToString(), reader["famille"].ToString(), reader["variete"].ToString(),
                                                          reader["observat"].ToString(), reader["notes"].ToString(), float.Parse(reader["prix_achat"].ToString()),
                                                          float.Parse(reader["prix_ttc"].ToString()), 
                                                          float.Parse(reader["prix_unit"].ToString()),
                                                          reader["taille"].ToString(), reader["photo"].ToString());

                        }


                    }
                }
            }

            return article;
        }

        public override List<Article> selectAll()
        {
            connect();
            List<Article> listArticle = new List<Article>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT article FROM articles ", _connection))
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
                                listArticle.Add(new Article(reader["article"].ToString()));
                            }
                        }
                    }
                }
            }
            return listArticle;
        }

        public override List<Article> selectAvecParam(string s)
        {
            connect();
            List<Article> listArticle = new List<Article>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM articles WHERE fourn ='" + s + "'", _connection))
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
                                listArticle.Add(new Article(reader["article"].ToString(), reader["design"].ToString(), reader["famille"].ToString(), reader["variete"].ToString(), float.Parse(reader["prix_achat"].ToString()), reader["taille"].ToString()));
                            }
                        }
                    }
                }
            }
            return listArticle;
        }

        public override List<Article> selectAvecParam2(string s)
        {
            connect();
            List<Article> listArticle = new List<Article>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("Select a.article,a.design from Articles a, devis_articles da, devis_entetes de where de.devis = da.devis and da.article = a.article  and de.client = '"+ s + "' AND date_devis = (select max(date_devis) from devis_entetes where client = '" + s + "')", _connection))
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
                                listArticle.Add(new Article(reader["article"].ToString()));
                            }
                        }
                    }
                }
            }
            return listArticle;            
        }

        public override bool update(Article obj)
        {
            throw new NotImplementedException();
        }
    }
}
