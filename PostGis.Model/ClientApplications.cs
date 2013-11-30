using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class ClientApplications
    {
        public ClientApplications() { }
        public int Id { get; set; }
        public Users Users { get; set; }
        public bool AllowWriteGpx { get; set; }
        public string Key { get; set; }
        public bool AllowReadGpx { get; set; }
        public string UpdatedAt { get; set; }
        public bool AllowReadPrefs { get; set; }
        public string Url { get; set; }
        public bool AllowWriteApi { get; set; }
        public string CreatedAt { get; set; }
        public string Name { get; set; }
        public bool AllowWritePrefs { get; set; }
        public bool AllowWriteDiary { get; set; }
        public string SupportUrl { get; set; }
        public string CallbackUrl { get; set; }
        public string Secret { get; set; }
    }
}
