using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tickets.Controllers
{
    public class CategoryController : ApiController
    {
        public IHttpActionResult GetCategory()
        {
            try {
            var q = BLL.CategoryBLL.GetCategories();
            if (q != null)
                return Ok(q);
            return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
