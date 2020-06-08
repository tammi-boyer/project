using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL
    {
       
            public static List<DTO.CategoryDto> GetCategories()
            {
                return Converters.category.ToDtocategoryList(DAL.CategoriesDal.SelectCategories());
            }
        
    }
}
