using FourNature.model.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao
{
    class FournisseurDAO : DAO<Fournisseur>
    {
        public FournisseurDAO():base(){ }

        public override bool create(Fournisseur obj)
        {
            return false;
        }

        public override bool delete(Fournisseur obj)
        {
            return false;
        }

        public override Fournisseur select(String fourn)
        {
            Fournisseur fournisseur = new Fournisseur();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM Fournisseurs WHERE fourn = '" + fourn +"'" , _connection))
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
                                fournisseur = new Fournisseur(reader["adresse_1"].ToString(), reader["adresse_2"].ToString(), reader["adresse_3"].ToString(), reader["code_post"].ToString(), reader["comment"].ToString(),
                                                              reader["e_mail"].ToString(), reader["fax"].ToString(), reader["fourn"].ToString(), reader["mots_clefs"].ToString(), reader["nom"].ToString(),
                                                              reader["nom_cor"].ToString(), reader["pays"].ToString(), reader["regl"].ToString(), reader["telephone"].ToString(), reader["telephone1"].ToString(),
                                                              reader["titre"].ToString(), reader["type_fournisseur"].ToString(), reader["ville"].ToString(), reader["www"].ToString(),Convert.ToInt32(reader["mt_franco"]));
                               
                            }


                        }
                    }
                }
            }
            return fournisseur;
        }

        public override bool update(Fournisseur obj)
        {
            return false;
        } 
    }
}

