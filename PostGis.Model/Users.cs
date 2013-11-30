using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Users
    {
        public Users() { }
        public long Id { get; set; }
        public string Email { get; set; }
        public bool EmailValid { get; set; }
        public string HomeLat { get; set; }
        public bool DataPublic { get; set; }
        public string Image { get; set; }
        public bool Visible { get; set; }
        public int Active { get; set; }
        public string DisplayName { get; set; }
        public string NewEmail { get; set; }
        public string CreationTime { get; set; }
        public string HomeLon { get; set; }
        public string Description { get; set; }
        public short? HomeZoom { get; set; }
        public string Languages { get; set; }
        public int? Nearby { get; set; }
        public string PassCrypt { get; set; }
        public string CreationIp { get; set; }
        public string PassSalt { get; set; }
    }
}
