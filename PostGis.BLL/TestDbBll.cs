using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostGis.DAL;
using PostGis.Model;

namespace PostGis.BLL
{
    public class TestDbBll
    {
        public void createDb()
        {
            using (var sessionFacory = SessionFactory.OpenSession())
            {
                Acls acls = new Acls { Address = "192.168.1.1", K = "123", V = "123", Netmask = "192.168.1.1" };
                sessionFacory.SaveOrUpdate(acls);
                sessionFacory.Close();
            }
        }
    }
}
