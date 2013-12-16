using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class AclsMap : ClassMapping<Acls>
    {
        public AclsMap()
        {
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.Netmask, map => map.NotNullable(true));
            Property(x => x.V);
            Property(x => x.Address, map => map.NotNullable(true));
            Property(x => x.K, map => map.NotNullable(true));
        }
    }
}
