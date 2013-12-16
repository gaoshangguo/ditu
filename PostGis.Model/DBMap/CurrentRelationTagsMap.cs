using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class CurrentRelationTagsMap : ClassMapping<CurrentRelationTags> {
        
        public CurrentRelationTagsMap() {
			Table("current_relation_tags");
			Schema("public");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.K, m => m.Column("k"));
					compId.Property(x => x.Id, m => m.Column("id"));
				});
			Property(x => x.V, map => map.NotNullable(true));
			ManyToOne(x => x.Id, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("id"), x => x.Name("id") }));
			ManyToOne(x => x.Id, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("id"), x => x.Name("id") }));
        }
    }
}
