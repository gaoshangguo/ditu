using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class UserTokensMap : ClassMapping<UserTokens> {
        
        public UserTokensMap() {
			Table("user_tokens");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Token, map => map.NotNullable(true));
			Property(x => x.Referer);
			Property(x => x.Expiry, map => map.NotNullable(true));
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id") }));
        }
    }
}
