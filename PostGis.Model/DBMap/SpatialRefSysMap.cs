using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class SpatialRefSysMap : ClassMapping<SpatialRefSys> {
        
        public SpatialRefSysMap() {
			Table("spatial_ref_sys");
			Schema("public");
			Lazy(true);
			Id(x => x.Srid, map => map.Generator(Generators.Assigned));
			Property(x => x.Srtext);
			Property(x => x.AuthSrid, map => map.Column("auth_srid"));
			Property(x => x.Proj4text);
			Property(x => x.AuthName, map => map.Column("auth_name"));
        }
    }
}
