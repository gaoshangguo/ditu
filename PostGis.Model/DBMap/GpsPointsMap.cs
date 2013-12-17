using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class GpsPointsMap : ClassMapping<GpsPoints>
    {
        public GpsPointsMap()
        {
            Table("gps_points");
            Schema("public");
            Lazy(true);
            Property(x => x.Tile);
            Property(x => x.Timestamp);
            Property(x => x.Altitude);
            Property(x => x.Trackid, map => map.NotNullable(true));
            Property(x => x.Latitude, map => map.NotNullable(true));
            Property(x => x.Longitude, map => map.NotNullable(true));
            ManyToOne(x => x.GpxFiles, map => { map.Column("gpx_id"); map.Cascade(Cascade.None); });
        }
    }
}
