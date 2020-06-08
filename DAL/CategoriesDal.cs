using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDal
    {
        public static List<category> SelectCategories()
        {
            using (ticketsEntities db = new ticketsEntities())
            {
                return db.categories.ToList();
            }

        }
    }
}
