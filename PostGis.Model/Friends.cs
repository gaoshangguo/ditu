using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Friends
    {
        public Friends()
        {
            FriendUsers = new List<Users>();
        }

        public virtual long Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual IList<Users> FriendUsers { get; set; }
    }
}
