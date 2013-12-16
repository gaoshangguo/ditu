using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class UserBlocksMap : ClassMapping<UserBlocks> {
        
        public UserBlocksMap() {
			Table("user_blocks");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.CreatorId, map => { map.Column("creator_id"); map.NotNullable(true); });
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.Reason, map => map.NotNullable(true));
			Property(x => x.CreatedAt, map => map.Column("created_at"));
			Property(x => x.EndsAt, map => { map.Column("ends_at"); map.NotNullable(true); });
			Property(x => x.NeedsView, map => { map.Column("needs_view"); map.NotNullable(true); });
			ManyToOne(x => x.RevokerId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("revoker_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.RevokerId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("revoker_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.RevokerId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("revoker_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
        }
    }
}
