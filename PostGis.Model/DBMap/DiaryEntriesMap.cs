using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class DiaryEntriesMap : ClassMapping<DiaryEntries> {
        
        public DiaryEntriesMap() {
			Table("diary_entries");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Body, map => map.NotNullable(true));
			Property(x => x.Title, map => map.NotNullable(true));
			Property(x => x.UpdatedAt, map => { map.Column("updated_at"); map.NotNullable(true); });
			Property(x => x.Longitude);
			Property(x => x.CreatedAt, map => { map.Column("created_at"); map.NotNullable(true); });
			Property(x => x.Latitude);
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id"), x => x.Name("language_code") }));
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id"), x => x.Name("language_code") }));
			ManyToOne(x => x., map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id"), x => x.Name("language_code") }));
			Bag(x => x.DiaryComments, colmap =>  { colmap.Key(x => x.Column("")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
