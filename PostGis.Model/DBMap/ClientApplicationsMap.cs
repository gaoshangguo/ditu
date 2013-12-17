using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class ClientApplicationsMap : ClassMapping<ClientApplications> {
        
        public ClientApplicationsMap() {
			Table("client_applications");
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.AllowWriteGpx, map => { map.Column("allow_write_gpx"); map.NotNullable(true); });
			Property(x => x.Key);
			Property(x => x.AllowReadGpx, map => { map.Column("allow_read_gpx"); map.NotNullable(true); });
			Property(x => x.UpdatedAt, map => map.Column("updated_at"));
			Property(x => x.AllowReadPrefs, map => { map.Column("allow_read_prefs"); map.NotNullable(true); });
			Property(x => x.Url);
			Property(x => x.AllowWriteApi, map => { map.Column("allow_write_api"); map.NotNullable(true); });
			Property(x => x.CreatedAt, map => map.Column("created_at"));
			Property(x => x.Name);
			Property(x => x.AllowWritePrefs, map => { map.Column("allow_write_prefs"); map.NotNullable(true); });
			Property(x => x.AllowWriteDiary, map => { map.Column("allow_write_diary"); map.NotNullable(true); });
			Property(x => x.SupportUrl, map => map.Column("support_url"));
			Property(x => x.CallbackUrl, map => map.Column("callback_url"));
			Property(x => x.Secret);
			ManyToOne(x => x.Users, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("user_id"), x => x.Name("user_id") }));
            Bag(x => x.OauthTokens, colmap => { colmap.Key(x => x.Column("client_application_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
