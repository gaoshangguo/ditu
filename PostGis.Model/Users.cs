using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Users : ITable
    {
        public Users() { }
        public virtual long Id { get; set; }
        public virtual string Email { get; set; }
        public virtual string NewEmail { get; set; }
        public virtual bool EmailValid { get; set; }
        public virtual double HomeLat { get; set; }
        public virtual double HomeLon { get; set; }
        public virtual short? HomeZoom { get; set; }
        public virtual int Active { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual string CreationIp { get; set; }
        public virtual string PassCrypt { get; set; }
        public virtual string PassSalt { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string Image { get; set; }
        public virtual bool Visible { get; set; }
        public virtual bool DataPublic { get; set; }
        public virtual string Languages { get; set; }
        public virtual string Description { get; set; }
        public virtual int? Nearby { get; set; }
    }
}
