using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGis.DAL.Providers
{
    public interface ISqlStatementProvider 
    {
        string DataProvider { get; }
        string GetStatement(string command);
    }
}
