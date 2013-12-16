using System;
using System.Text;
using System.Collections.Generic;


namespace PostGis.Model
{
    public class Acls
    {
        public virtual int Id { get; set; }
        public virtual string Netmask { get; set; }
        public virtual string V { get; set; }
        public virtual string Address { get; set; }
        public virtual string K { get; set; }
    }
}
