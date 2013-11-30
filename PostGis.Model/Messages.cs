using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Messages
    {
        public long Id { get; set; }
        public Users Users { get; set; }
        public string Body { get; set; }
        public string Title { get; set; }
        public string SentOn { get; set; }
        public bool MessageRead { get; set; }
        public bool FromUserVisible { get; set; }
        public bool ToUserVisible { get; set; }
    }
}
