using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using PostGis.DAL.Providers;
using Configuration = NHibernate.Cfg.Configuration;

namespace PostGis.DAL
{
    public class SessionFactory
    {
        private static ISessionFactory sessionFactory;

        private static readonly object Padlock = new object();

        public static ISession OpenSession()
        {
            if (sessionFactory == null)
            {
                lock (Padlock)
                {
                    if (sessionFactory == null)
                    {
                        BuildSessionFactory();
                    }
                }
            }
            return sessionFactory.OpenSession();
        }

        private static void BuildSessionFactory()
        {
            PgSqlDataServicesProvider pgSqlDataServices = new PgSqlDataServicesProvider(ConfigurationManager.ConnectionStrings["MyDbContext"].ToString());
            sessionFactory = pgSqlDataServices.CreateSessionFactory();
        }
    }
}
