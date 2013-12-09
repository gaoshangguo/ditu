using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostGis.DAL.Providers
{
    public interface IDataServicesProviderFactory
    {
        IDataServicesProvider CreateProvider(DataServiceParameters sessionFactoryParameters);
    }
}
