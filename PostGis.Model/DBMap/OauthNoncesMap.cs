using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class OauthNoncesMap : ClassMapping<OauthNonces> {
        
        public OauthNoncesMap() {
			Table("oauth_nonces");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.Nonce);
			Property(x => x.CreatedAt, map => map.Column("created_at"));
			Property(x => x.Timestamp);
        }
    }
}
