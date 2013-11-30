using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class NodeTags
    {
        public string K { get; set; }
        public long Idid { get; set; }
        public long Version { get; set; }
        public Nodes Nodes { get; set; }
        public string V { get; set; }
    }
}
