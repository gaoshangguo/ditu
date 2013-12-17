using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class CurrentWaysMap : ClassMapping<CurrentWays>
    {
        public CurrentWaysMap() {
			Table("current_ways");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Version, map => map.NotNullable(true));
			Property(x => x.Visible, map => map.NotNullable(true));
			Property(x => x.Timestamp, map => map.NotNullable(true));
			ManyToOne(x => x.Changesets, map => { map.Column("changeset_id"); map.Cascade(Cascade.None); });
            Bag(x => x.CurrentWayNodes, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
			Bag(x => x.CurrentWayTags, colmap =>  { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
