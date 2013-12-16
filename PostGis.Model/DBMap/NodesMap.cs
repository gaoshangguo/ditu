using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class NodesMap : ClassMapping<Nodes> {
        
        public NodesMap() {
			Schema("public");
			Lazy(true);
			ComposedId(compId =>
				{
					compId.Property(x => x.Id, m => m.Column("id"));
					compId.Property(x => x.Version, m => m.Column("version"));
				});
			Property(x => x.Visible, map => map.NotNullable(true));
			Property(x => x.Tile, map => map.NotNullable(true));
			Property(x => x.Timestamp, map => map.NotNullable(true));
			Property(x => x.Latitude, map => map.NotNullable(true));
			Property(x => x.Longitude, map => map.NotNullable(true));
			ManyToOne(x => x., map => { map.Column("changeset_id"); map.Cascade(Cascade.None); });

			Bag(x => x.NodeTags, colmap =>  { colmap.Key(x => x.Column("")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
