using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class UserRolesMap : ClassMapping<UserRoles> {
        
        public UserRolesMap() {
			Table("user_roles");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.Role, map => map.NotNullable(true));
			Property(x => x.CreatedAt, map => map.Column("created_at"));
			ManyToOne(x => x.GranterId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("granter_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.GranterId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("granter_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.GranterId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("granter_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
        }
    }
}
