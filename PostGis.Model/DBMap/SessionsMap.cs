using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class SessionsMap : ClassMapping<Sessions> {
        
        public SessionsMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.SessionId, map => map.Column("session_id"));
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.Data);
			Property(x => x.CreatedAt, map => map.Column("created_at"));
        }
    }
}
