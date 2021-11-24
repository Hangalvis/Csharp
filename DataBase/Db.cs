using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataBase
{
    public abstract class  Db
    {
        private string _conexionstring;
        protected SqlConnection _conexion;

        public Db(string server, string db, string user, string password)
        {
            _conexionstring = $"Data Source={server};Initial Catalog={db};" +
                $"User={user};Password={password}";
        }

        public Db(string dblocal)
        {
            _conexionstring = $"{dblocal}";
        }

        public void open()
        {
           
            _conexion = new SqlConnection(_conexionstring);
            _conexion.Open();
        }

        public void close()
        {
            if (_conexion != null && _conexion.State == System.Data.ConnectionState.Open)
                _conexion.Close();
        }

    }
}
