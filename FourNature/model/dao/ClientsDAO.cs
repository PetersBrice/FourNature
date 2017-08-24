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
    class ClientsDAO : DAO<Clients>
    {
        public ClientsDAO():base(){ }

        public override bool create(Clients obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("DELETE FROM clients WHERE client = '" + s + "'", _connection))
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

        public override Clients select(string s)
        {
            Clients client = null;
            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("SELECT * FROM clients WHERE client = '" + s + "'", _connection))
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
                            client = new Clients(reader["client"].ToString(),
                                reader["adresse_1"].ToString(),
                                reader["adresse_2"].ToString(),
                                reader["adresse_3"].ToString(),
                                reader["ville"].ToString(),
                                reader["code_post"].ToString(),
                                reader["e_mail"].ToString(),
                                reader["telephone"].ToString(),
                                reader["telephone1"].ToString(),
                                reader["telephone2"].ToString());
                        }
                    }
                }
            }

            return client;
        }

        public override List<Clients> selectAll()
        {
            connect();
            List<Clients> listCLients = new List<Clients>();
            {
                using (_connection)
                {
                    using (_cmd = new OleDbCommand("SELECT client FROM clients ", _connection))
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
                                listCLients.Add(new Clients(reader["client"].ToString()));
                            }
                        }
                    }
                }
            }
            return listCLients;
        }

        public override List<Clients> selectAvecParam(string s)
        {
            throw new NotImplementedException();
        }

        public override bool update(Clients obj)
        {
            throw new NotImplementedException();
        }
    }
}
