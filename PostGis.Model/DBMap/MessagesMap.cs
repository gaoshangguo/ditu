using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using PostGis.Model;


namespace PostGis.Model.DBMap {
    
    
    public class MessagesMap : ClassMapping<Messages> {
        
        public MessagesMap() {
			Schema("public");
			Lazy(true);
			Id(x => x.Id, map => map.Generator(Generators.Assigned));
			Property(x => x.Body, map => map.NotNullable(true));
			Property(x => x.Title, map => map.NotNullable(true));
			Property(x => x.SentOn, map => { map.Column("sent_on"); map.NotNullable(true); });
			Property(x => x.MessageRead, map => { map.Column("message_read"); map.NotNullable(true); });
			Property(x => x.FromUserVisible, map => { map.Column("from_user_visible"); map.NotNullable(true); });
			Property(x => x.ToUserVisible, map => { map.Column("to_user_visible"); map.NotNullable(true); });
			ManyToOne(x => x.FromUserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("from_user_id"), x => x.Name("to_user_id") }));
			ManyToOne(x => x.FromUserId, map => map.Columns(new Action<IColumnMapper>[] { x => x.Name("from_user_id"), x => x.Name("to_user_id") }));
        }
    }
}
