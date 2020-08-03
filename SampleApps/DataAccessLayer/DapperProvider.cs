using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq.Functions;
using Npgsql;

namespace DataAccessLayer
{
    public class DapperProvider
    {
        private NpgsqlConnection _connection;
        private string connectionString = $"Server=localhost;Port=5432;Database=DTECoalHandling;User Id=inass4;Password=123;";
        private DapperProvider()
        {
            
        }
        private static DapperProvider _instance=new DapperProvider();

        public static DapperProvider Instance
        {
            get { return _instance; }
        }
        
        public NpgsqlConnection GetConnection()
        {
            _connection=new NpgsqlConnection();
            _connection.ConnectionString = connectionString;
            return _connection;
        }
    }
}
