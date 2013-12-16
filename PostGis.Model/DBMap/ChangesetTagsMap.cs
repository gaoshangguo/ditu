using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap
{
    public class ChangesetTagsMap : ClassMapping<ChangesetTags>
    {
        public ChangesetTagsMap()
        {
            Table("changeset_tags");
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.K, map => map.NotNullable(true));
            Property(x => x.V, map => map.NotNullable(true));
            ManyToOne(x => x.Changesets, map => map.Column("id"));
        }
    }
}
