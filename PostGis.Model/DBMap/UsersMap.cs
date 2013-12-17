using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;

namespace PostGis.Model.DBMap
{
    public class UsersMap : ClassMapping<Users>
    {
        public UsersMap()
        {
            Schema("public");
            Lazy(true);
            Id(x => x.Id, map => map.Generator(Generators.Assigned));
            Property(x => x.Email, map => map.NotNullable(true));
            Property(x => x.EmailValid, map => { map.Column("email_valid"); map.NotNullable(true); });
            Property(x => x.HomeLat, map => map.Column("home_lat"));
            Property(x => x.DataPublic, map => { map.Column("data_public"); map.NotNullable(true); });
            Property(x => x.Image);
            Property(x => x.Visible, map => map.NotNullable(true));
            Property(x => x.Active, map => map.NotNullable(true));
            Property(x => x.DisplayName, map => { map.Column("display_name"); map.NotNullable(true); });
            Property(x => x.NewEmail, map => map.Column("new_email"));
            Property(x => x.CreationTime, map => { map.Column("creation_time"); map.NotNullable(true); });
            Property(x => x.HomeLon, map => map.Column("home_lon"));
            Property(x => x.Description, map => map.NotNullable(true));
            Property(x => x.HomeZoom, map => map.Column("home_zoom"));
            Property(x => x.Languages);
            Property(x => x.Nearby);
            Property(x => x.PassCrypt, map => { map.Column("pass_crypt"); map.NotNullable(true); });
            Property(x => x.CreationIp, map => map.Column("creation_ip"));
            Property(x => x.PassSalt, map => map.Column("pass_salt"));
            Bag(x => x.Changesets, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.ClientApplications, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.DiaryComments, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.DiaryEntries, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.Friends, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.GpxFiles, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.Messages, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.OauthTokens, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.UserBlocks, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.UserPreferences, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.UserRoles, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
            Bag(x => x.UserTokens, colmap => { colmap.Key(x => x.Column("user_id")); colmap.Inverse(true); }, map => { map.OneToMany(); });
        }
    }
}
