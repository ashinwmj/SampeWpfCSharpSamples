using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.ConfigurationSchema;
using NHibernate.Dialect;

namespace DataAccessLayer
{
  public  sealed  class NHibernateProvider
  {
        public static NHibernateProvider Instance { get; } = new NHibernateProvider();


        private ISessionFactory _sessionFactory;
        public NHibernateProvider()
        {
            Initialize();
        }

        private void Initialize()
        {
            var cfg = new Configuration();
            cfg.Properties.Add(NHibernate.Cfg.Environment.ConnectionDriver, "NHibernate.Connection.DriverConnectionProvider");
            cfg.Properties.Add(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.PostgreSQL82Dialect");
            cfg.Properties.Add(NHibernate.Cfg.Environment.ConnectionString, GetConnectionString());
            cfg.Properties.Add(NHibernate.Cfg.Environment.Hbm2ddlKeyWords, "none");
            cfg.Properties.Add(NHibernate.Cfg.Environment.ShowSql, "false");
            cfg.Properties.Add(NHibernate.Cfg.Environment.FormatSql, "true");
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            _sessionFactory = cfg.BuildSessionFactory();

        }

        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }
        private string GetConnectionString()
        {
            var connectionString = $"Server=\"localhost\";Port=5432;Database=NEWDCS;" +
                                   $"User Id={System.Environment.UserName.ToLower()};Integrated Security=true;" +
                                   "SslMode = Require;";
                                   
            return connectionString;
        }
    }

  public class Client
  {
      public void GeSignalList()
      {
          using (var session=NHibernateProvider.Instance.GetSession())
          {
              using (var tx=session.BeginTransaction())
              {
             
              }
          }
      }
  }
}

