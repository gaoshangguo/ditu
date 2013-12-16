using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class CurrentWayNodesMap : ClassMapping<CurrentWayNodes> {
        
        public CurrentWayNodesMap() {
			Table("current_way_nodes");
			Schema("public");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.SequenceId, m => m.Column("sequence_id"));
					compId.Property(x => x.Id, m => m.Column("id"));
				});
			ManyToOne(x => x., map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("node_id"), x => x.Name("id"), x => x.Name("id") }));
			ManyToOne(x => x.NodeId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("node_id"), x => x.Name("id"), x => x.Name("id") }));
			ManyToOne(x => x.NodeId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("node_id"), x => x.Name("id"), x => x.Name("id") }));
        }
    }
}
