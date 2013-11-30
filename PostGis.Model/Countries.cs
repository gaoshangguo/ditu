using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostGis.Model
{
    public class Countries
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string MaxLon { get; set; }
        public string MinLat { get; set; }
        public string MinLon { get; set; }
        public string MaxLat { get; set; }
    }
}
