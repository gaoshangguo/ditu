using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class RelationMembers
    {
        public string MemberRole { get; set; }
        public long MemberId { get; set; }
        public long MemberType { get; set; }
        public long Idid { get; set; }
        public long Version { get; set; }
        public int SequenceId { get; set; }
        public Relations Relations { get; set; }
    }
}
