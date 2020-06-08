using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryDto
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public Nullable<int> subcategoryId { get; set; }
    }
}
