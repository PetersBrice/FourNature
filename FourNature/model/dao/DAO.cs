using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourNature.model.dao
{
    abstract class DAO<T>
    {
        protected static OleDbConnection _connection;
        protected static OleDbCommand _cmd;

        public DAO()
        {
            //add here your connection details
            String connectionString = "../../ressource/DreamFloreDB10.mdb";

            //create a connection to the database
            _connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + connectionString);
            _connection.Open();
        }
        public abstract Boolean create(T obj);
        public abstract Boolean delete(T obj);
        public abstract Boolean update(T obj);
        public abstract T select(String fourn);

       
    }
}
