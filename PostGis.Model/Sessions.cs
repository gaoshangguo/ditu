using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Sessions
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string UpdatedAt { get; set; }
        public string Data { get; set; }
        public string CreatedAt { get; set; }
    }
}
