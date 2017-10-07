using FourNature.model.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourNature.model.dao
{
    class FournisseurDAO : DAO<Fournisseur>
    {
        public FournisseurDAO():base(){ }

        public override bool create(Fournisseur obj)
        {
            return false;
        }

        public override void delete(String s)
        {
            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("DELETE FROM Fournisseurs WHERE fourn = '" + s + "'", _connection))
                {

                    // Execution de la requette et lecture du résultat en mode connecté
                    OleDbDataReader reader = _cmd.ExecuteReader();

                    //Console.WriteLine("Request created.");
                    //Si le résultat comporte des lignes
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("Fournisseur supprimé avec succès!");
                        
                    }
                    else MessageBox.Show("Erreur!");
                }
            }
        }

        public override Fournisseur select(String s)
        {
          
            Fournisseur fournisseur = new Fournisseur();
            
                connect();
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT * FROM Fournisseurs WHERE fourn = '" + s +"'" , _connection))
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
            
            return fournisseur;
        }

        public override List<Fournisseur> selectAll()
        {
            connect();
            List<Fournisseur> listFournisseur = new List<Fournisseur>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT fourn FROM Fournisseurs ", _connection))
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
                                listFournisseur.Add(new Fournisseur(reader["fourn"].ToString()));
                            }
                        }
                    }
                }
            }
            return listFournisseur;
        }

        public override List<Fournisseur> selectAvecParam(string s)
        {
            throw new NotImplementedException();
        }

        public override List<Fournisseur> selectAvecParam2(string s)
        {
            throw new NotImplementedException();
        }

        public override bool update(Fournisseur obj)
        {
            return false;
        } 
    }
}

