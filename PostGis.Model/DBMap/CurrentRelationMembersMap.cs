using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class CurrentRelationMembersMap : ClassMapping<CurrentRelationMembers>
    {
        public CurrentRelationMembersMap()
        {
            Table("current_relation_members");
            Schema("public");
            Lazy(true);
            ComposedId(compId =>
                {
                    compId.Property(x => x.MemberRole, m => m.Column("member_role"));
                    compId.Property(x => x.MemberId, m => m.Column("member_id"));
                    compId.Property(x => x.MemberType, m => m.Column("member_type"));
                    compId.Property(x => x.Id, m => m.Column("id"));
                    compId.Property(x => x.SequenceId, m => m.Column("sequence_id"));
                });
            ManyToOne(x => x.CurrentRelations, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("id"), x => x.Name("id") }));
        }
    }
}
