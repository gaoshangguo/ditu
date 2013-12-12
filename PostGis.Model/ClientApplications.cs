using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class ClientApplications : ITable
    {
        public ClientApplications() { }
        public virtual int Id { get; set; }
        public virtual Users Users { get; set; }
        public virtual bool AllowWriteGpx { get; set; }
        public virtual string Key { get; set; }
        public virtual bool AllowReadGpx { get; set; }
        public virtual string UpdatedAt { get; set; }
        public virtual bool AllowReadPrefs { get; set; }
        public virtual string Url { get; set; }
        public virtual bool AllowWriteApi { get; set; }
        public virtual string CreatedAt { get; set; }
        public virtual string Name { get; set; }
        public virtual bool AllowWritePrefs { get; set; }
        public virtual bool AllowWriteDiary { get; set; }
        public virtual string SupportUrl { get; set; }
        public virtual string CallbackUrl { get; set; }
        public virtual string Secret { get; set; }
    }
}
