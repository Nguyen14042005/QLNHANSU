using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class DANTOC
    {
        QUANLYNHANSUEntities1 db = new QUANLYNHANSUEntities1();
        public tb_DanToc getItem(int id)
        {
            return db.tb_DanToc.FirstOrDefault(x => x.ID == id);
        }
        public List<tb_DanToc> getList()
        {
            return db.tb_DanToc.ToList();
        }

        public tb_DanToc Add(tb_DanToc dt)
        {
            try
            {
                db.tb_DanToc.Add(dt);
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public tb_DanToc Update(tb_DanToc dt)
        {
            try
            {
                var _dt = db.tb_DanToc.FirstOrDefault(x => x.ID == dt.ID);
                _dt.TENDT = dt.TENDT;
                db.SaveChanges();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var _dt = db.tb_DanToc.FirstOrDefault(x => x.ID == id);
                db.tb_DanToc.Remove(_dt);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
