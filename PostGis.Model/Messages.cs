using System;
using System.Text;
using System.Collections.Generic;

namespace PostGis.Model
{
    public class Messages
    {
        public virtual long Id { get; set; }
        public virtual string Body { get; set; }
        public virtual string Title { get; set; }
        public virtual string SentOn { get; set; }
        public virtual bool MessageRead { get; set; }
        public virtual Users FromUser { get; set; }
        public virtual Users ToUser { get; set; }
        public virtual bool FromUserVisible { get; set; }
        public virtual bool ToUserVisible { get; set; }
    }
}
