﻿using FourNature.model.dao.metier;
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
                    using (_cmd = new OleDbCommand("SELECT ncde FROM Commandes_articles ", _connection))
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
                                listCommandes.Add(new Commandes_articles(reader["ncde"].ToString()));
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

        public override bool update(Commandes_articles obj)
        {
            throw new NotImplementedException();
        }
    }
}