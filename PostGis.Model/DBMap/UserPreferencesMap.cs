using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class UserPreferencesMap : ClassMapping<UserPreferences> {
        
        public UserPreferencesMap() {
			Table("user_preferences");
			Schema("public");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.K, m => m.Column("k"));
					compId.Property(x => x.UserId, m => m.Column("user_id"));
				});
			Property(x => x.V, map => map.NotNullable(true));
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id") }));
        }
    }
}
