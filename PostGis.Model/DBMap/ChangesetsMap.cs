using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class ChangesetsMap : ClassMapping<Changesets>
    {
        public ChangesetsMap()
        {
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.MinLat, map => map.Column("min_lat"));
            Property(x => x.MaxLon, map => map.Column("max_lon"));
            Property(x => x.MinLon, map => map.Column("min_lon"));
            Property(x => x.MaxLat, map => map.Column("max_lat"));
            Property(x => x.ClosedAt, map => { map.Column("closed_at"); map.NotNullable(true); });
            Property(x => x.CreatedAt, map => { map.Column("created_at"); map.NotNullable(true); });
            Property(x => x.NumChanges, map => { map.Column("num_changes"); map.NotNullable(true); });
            ManyToOne(x => x.Users, map => map.Column("user_id"));
            Bag(x => x.ChangesetTags, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.CurrentNodes, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.CurrentRelations, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.CurrentWays, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.Nodes, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.Relations, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.Ways, colmap => { colmap.Key(x => x.Column("id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
