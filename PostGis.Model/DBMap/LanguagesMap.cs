using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap {
    public class LanguagesMap : ClassMapping<Languages> {
        public LanguagesMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Code, map => map.Generator(Generators.Assigned));
			Property(x => x.EnglishName, map => { map.Column("english_name"); map.NotNullable(true); });
			Property(x => x.NativeName, map => map.Column("native_name"));
            Bag(x => x.DiaryEntries, colmap => { colmap.Key(x => x.Column("language_code")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
