using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class RelationMembers
    {
        public virtual string MemberRole { get; set; }
        public virtual long MemberId { get; set; }
        public virtual long MemberType { get; set; }
        public virtual long Idid { get; set; }
        public virtual long Version { get; set; }
        public virtual int SequenceId { get; set; }
        public virtual Relations Relations { get; set; }
    }
}
