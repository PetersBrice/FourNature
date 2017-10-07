using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature.model.dao
{
    class Commandes_articlesDAO : DAO<Commandes_articles>
    {
        public override bool create(Commandes_articles obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("DELETE FROM Commandes_articles WHERE ncde = '" + s + "'", _connection))
                {

                    // Execution de la requette et lecture du résultat en mode connecté
                    OleDbDataReader reader = _cmd.ExecuteReader();

                    //Console.WriteLine("Request created.");
                    //Si le résultat comporte des lignes
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Commande supprimée avec succès!");

                    }
                    else MessageBox.Show("Erreur!");
                }
            }
        }

        public override Commandes_articles select(string s)
        {
            Commandes_articles commande = new Commandes_articles();

            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("SELECT * FROM Commandes_articles WHERE ncde = '" + s + "'", _connection))
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
                            commande = new Commandes_articles(reader["ncde"].ToString(), reader["article"].ToString(), reader["design"].ToString(), reader["fourn"].ToString(), reader["famille"].ToString(),
                                                          reader["lot"].ToString(), reader["notes"].ToString(), float.Parse(reader["prix_achat"].ToString()), float.Parse(reader["qte_cde"].ToString()), float.Parse(reader["prix_unit"].ToString()));
                        }

                    }
                }
            }

            return commande;
        }

        public override List<Commandes_articles> selectAll()
        {
            connect();
            List<Commandes_articles> listCommandes = new List<Commandes_articles>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("Select ca.ncde,article,design,fourn,famille,lot,notes,prix_achat,qte_cde,prix_unit FROM commandes_articles ca, commandes_entetes ce where ca.ncde = ce.ncde AND date_accept = (select max(date_accept) from commandes_entetes) ORDER BY prix_achat desc", _connection))
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
                                listCommandes.Add(new Commandes_articles(reader["ncde"].ToString(), reader["article"].ToString(), reader["design"].ToString(), reader["fourn"].ToString(), reader["famille"].ToString(),
                                                          reader["lot"].ToString(), reader["notes"].ToString(), float.Parse(reader["prix_achat"].ToString()), float.Parse(reader["qte_cde"].ToString()), float.Parse(reader["prix_unit"].ToString())));
                            }
                        }
                    }
                }
            }
            return listCommandes;
        }

        public override List<Commandes_articles> selectAvecParam(string s)
        {
            connect();
            List<Commandes_articles> listCommandes = new List<Commandes_articles>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM Commandes_articles WHERE ncde = '" + s + "'", _connection))
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
                                listCommandes.Add(new Commandes_articles(reader["ncde"].ToString(), reader["article"].ToString(), reader["design"].ToString(), reader["fourn"].ToString(), reader["famille"].ToString(),
                                                          reader["lot"].ToString(), reader["notes"].ToString(), float.Parse(reader["prix_achat"].ToString()), float.Parse(reader["qte_cde"].ToString()), float.Parse(reader["prix_unit"].ToString())));
                            }
                        }
                    }
                }
            }
            return listCommandes;
        }

        public override List<Commandes_articles> selectAvecParam2(string s)
        {
            throw new NotImplementedException();
        }

        public override bool update(Commandes_articles obj)
        {
            connect();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("UPDATE Commandes_articles SET fourn ='" + obj.Fourn + "',prix_achat ='" + obj.Prix_achat + "' WHERE ncde ='" + obj.Ncde + "' AND article ='" + obj.Article + "'", _connection))
                    {
                        if (_cmd.ExecuteNonQuery() == -1)
                        {
                            MessageBox.Show("Erreur modification");
                        }
                        else MessageBox.Show("La commande a été modifiée avec succès !");

                        }
                }
            }
            return true;
        }
    }
}
                