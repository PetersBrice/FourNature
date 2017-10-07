using FourNature.model.dao.metier;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao
{
    class Devis_entetesDAO : DAO<Devis_entetes>
    {
        public override bool create(Devis_entetes obj)
        {
            throw new NotImplementedException();
        }

        public override void delete(string s)
        {
            throw new NotImplementedException();
        }

        public override Devis_entetes select(string s)
        {
            throw new NotImplementedException();
        }

        public override List<Devis_entetes> selectAll()
        {
            throw new NotImplementedException();
        }

        public override List<Devis_entetes> selectAvecParam(string s)
        {
            throw new NotImplementedException();
        }

        public override bool update(Devis_entetes obj)
        {
            throw new NotImplementedException();
        }
        public Devis_entetes selectDevis(Clients c)
        {
            Devis_entetes devis = new Devis_entetes();

            connect();
            using (_connection)
            {
                using (_cmd = new OleDbCommand("SELECT * FROM Devis_entetes WHERE client = '" + c.Client + "' AND adresse_1 ='" + c.Adresse_1 + "' OR adresse_1 ='' AND adresse_2 ='" + c.Adresse_2 + "' OR adresse_2 = '' AND adresse_3 ='" + c.Adresse_3 + "' OR adresse_3 = ''", _connection))
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
                            devis = new Devis_entetes(reader["devis"].ToString(), reader["client"].ToString(), reader["adresse_1"].ToString(), reader["adresse_2"].ToString(), reader["adresse_3"].ToString());
                        }

                    }
                }
            }
            return devis;
        }

        public override List<Devis_entetes> selectAvecParam2(string s)
        {
            throw new NotImplementedException();
        }
    }
}
