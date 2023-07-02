using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DalDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if(p.Basogrid!=null && p.Basdersid != null)
            {
                return DalDers.TalepEkle(p);
            }
            return -1;
        }
    }
}
