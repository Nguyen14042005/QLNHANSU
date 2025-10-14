using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class TRINHDO
    {
        QUANLYNHANSUEntities1 db = new QUANLYNHANSUEntities1();

        public List<tb_TRINHDO> getList()
        {
            return db.tb_TRINHDO.ToList();
        }
    }
}
