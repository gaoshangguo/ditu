using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class SchemaMigrationsMap : ClassMapping<SchemaMigrations> {
        
        public SchemaMigrationsMap() {
			Table("schema_migrations");
			Schema("public");
			Lazy(true);
			Property(x => x.Version, map => map.NotNullable(true));
        }
    }
}
