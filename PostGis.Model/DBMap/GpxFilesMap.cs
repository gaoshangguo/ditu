using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class GpxFilesMap : ClassMapping<GpxFiles>
    {
        public GpxFilesMap()
        {
            Table("gpx_files");
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.Size);
            Property(x => x.Visible, map => map.NotNullable(true));
            Property(x => x.Timestamp, map => map.NotNullable(true));
            Property(x => x.Description, map => map.NotNullable(true));
            Property(x => x.Name, map => map.NotNullable(true));
            Property(x => x.Longitude);
            Property(x => x.Inserted, map => map.NotNullable(true));
            Property(x => x.Visibility, map => map.NotNullable(true));
            Property(x => x.Latitude);
            ManyToOne(x => x.Users, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id") }));
            Bag(x => x.GpsPoints, colmap => { colmap.Key(x => x.Column("gpx_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.GpxFileTags, colmap => { colmap.Key(x => x.Column("gpx_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
