using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.DAL.Providers
{
    class PgSqlStatementProvider : ISqlStatementProvider
    {
        public string DataProvider
        {
            get { return "PgSql"; }
        }

        public string GetStatement(string command)
        {
            switch (command)
            {
                case "random":
                    return "rand()";
            }

            return null;
        }
    }
}
