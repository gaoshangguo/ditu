using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class DiaryCommentsMap : ClassMapping<DiaryComments>
    {
        public DiaryCommentsMap()
        {
            Table("diary_comments");
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.Body, map => map.NotNullable(true));
            Property(x => x.UpdatedAt, map => { map.Column("updated_at"); map.NotNullable(true); });
            Property(x => x.CreatedAt, map => { map.Column("created_at"); map.NotNullable(true); });
            ManyToOne(x => x.DiaryEntries, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("diary_entry_id") }));
            ManyToOne(x => x.Users, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id") }));
        }
    }
}
