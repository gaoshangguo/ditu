using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class WayNodesMap : ClassMapping<WayNodes> {
        
        public WayNodesMap() {
			Table("way_nodes");
			Schema("public");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.SequenceId, m => m.Column("sequence_id"));
					compId.Property(x => x.Id, m => m.Column("id"));
					compId.Property(x => x.Version, m => m.Column("version"));
				});
			Property(x => x.NodeId, map => { map.Column("node_id"); map.NotNullable(true); });
			ManyToOne(x => x.Id, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("id"), x => x.Name("id") }));
			ManyToOne(x => x.Id, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("id"), x => x.Name("id") }));
        }
    }
}
