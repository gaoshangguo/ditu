using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class GpxFileTagsMap : ClassMapping<GpxFileTags> {
        
        public GpxFileTagsMap() {
			Table("gpx_file_tags");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Tag, map => map.NotNullable(true));
			ManyToOne(x => x., map => { map.Column("gpx_id"); map.Cascade(Cascade.None); });

        }
    }
}
