using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALL
    {
        LapStoresEntities c1 = null;
        public DALL()
        {
            c1 = new LapStoresEntities();
        }
        public List<lapbrand> listallbrands()
        {
            return c1.lapbrands.ToList();
        }
        public class loginmethods
        {
            LapStoresEntities c1 = null;
            public loginmethods()
            {
                c1 = new LapStoresEntities();
            }
            public bool addlogin(logintable t)
            {
                try
                {
                    c1.logintables.Add(t);
                    c1.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return false;
                }
            }
            public bool checklogin(logintable t)
            {

                List<logintable> list = c1.logintables.ToList();
                bool k = false;
                foreach (var item in list)
                {
                    if (t.customerid == item.customerid && t.customername == item.customername)
                    {
                        k = true;
                    }
                }
                return k;

            }

        }
        public class ordermethods
        {
            LapStoresEntities c1 = null;
            public ordermethods()
            {
                c1 = new LapStoresEntities();
            }
            public bool addorder(placedorder p)
            {
                try
                {
                    c1.placedorders.Add(p);
                    c1.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    return false;
                }

            }
            public bool removeorder(int id)
            {
                try
                {
                    placedorder pt = c1.placedorders.Find(id);
                    c1.placedorders.Remove(pt);
                    c1.SaveChanges();
                    return true;

                }
                catch
                {
                    return false;
                }
            }
            public List<placedorder> listbycustid(int id)
            {
                List<placedorder> m = c1.placedorders.ToList();
                m = m.Where(p => p.customerid == id).ToList();
                return m;
            }


        }
    }
}
