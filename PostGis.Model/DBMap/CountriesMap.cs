using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class CountriesMap : ClassMapping<Countries> {
        
        public CountriesMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Code, map => map.NotNullable(true));
			Property(x => x.MaxLon, map => { map.Column("max_lon"); map.NotNullable(true); });
			Property(x => x.MinLat, map => { map.Column("min_lat"); map.NotNullable(true); });
			Property(x => x.MinLon, map => { map.Column("min_lon"); map.NotNullable(true); });
			Property(x => x.MaxLat, map => { map.Column("max_lat"); map.NotNullable(true); });
        }
    }
}
