using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class ConststringMap : ClassMapping<Conststring> {
        
        public ConststringMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.T, map => map.NotNullable(true));
			Property(x => x.V);
			Property(x => x.K, map => map.NotNullable(true));
        }
    }
}
