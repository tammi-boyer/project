using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace Converters
{
    public class category
    {
        public static DAL.category ToDalcategory(DTO.CategoryDto c)
        {
            DAL.category ca = new DAL.category();
            ca.categoryId = c.categoryId;
            ca.categoryName = c.categoryName;
            //ca.subcategoryId = c.subcategoryId;
            return ca;
        }

  

        public static DTO.CategoryDto ToDtocategory(DAL.category c)
        {
            DTO.CategoryDto ca = new DTO.CategoryDto();
            ca.categoryId = c.categoryId;
            ca.categoryName = c.categoryName;
            //ca.subcategoryId = c.subcategoryId;
            return ca;
        }
        public static List<DAL.category> ToDalcategoryList(List<DTO.CategoryDto> lc)
        {
            List<DAL.category> lca = new List<DAL.category>();
          foreach (var item in lc)
            {
                lca.Add(ToDalcategory(item));
            }
            return lca;
        }
        public static List<DTO.CategoryDto> ToDtocategoryList(List<DAL.category> lc)
        {
            List<DTO.CategoryDto> lca = new List<DTO.CategoryDto>();
            foreach (var item in lc)
            {
                lca.Add(ToDtocategory(item));
            }
            return lca;
        }
    }
}
