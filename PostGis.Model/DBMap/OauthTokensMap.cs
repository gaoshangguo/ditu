using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class OauthTokensMap : ClassMapping<OauthTokens> {
        
        public OauthTokensMap() {
			Table("oauth_tokens");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Token);
			Property(x => x.Type);
			Property(x => x.InvalidatedAt, map => map.Column("invalidated_at"));
			Property(x => x.AllowWriteGpx, map => { map.Column("allow_write_gpx"); map.NotNullable(true); });
			Property(x => x.AllowReadGpx, map => { map.Column("allow_read_gpx"); map.NotNullable(true); });
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.AllowReadPrefs, map => { map.Column("allow_read_prefs"); map.NotNullable(true); });
			Property(x => x.AllowWriteApi, map => { map.Column("allow_write_api"); map.NotNullable(true); });
			Property(x => x.AuthorizedAt, map => map.Column("authorized_at"));
			Property(x => x.CreatedAt, map => map.Column("created_at"));
			Property(x => x.AllowWritePrefs, map => { map.Column("allow_write_prefs"); map.NotNullable(true); });
			Property(x => x.AllowWriteDiary, map => { map.Column("allow_write_diary"); map.NotNullable(true); });
			Property(x => x.Secret);
			ManyToOne(x => x.UserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("client_application_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.ClientApplications, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("client_application_id"), x => x.Name("user_id") }));
        }
    }
}
