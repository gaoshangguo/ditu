using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class FriendsMap : ClassMapping<Friends> {
        
        public FriendsMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			ManyToOne(x => x.FriendUserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("friend_user_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.FriendUserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("friend_user_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
			ManyToOne(x => x.FriendUserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("friend_user_id"), x => x.Name("user_id"), x => x.Name("user_id") }));
        }
    }
}
