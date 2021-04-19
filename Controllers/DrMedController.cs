using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACPDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrMedController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
              

                return Ok(lst);
            }

            // return new string[] { "value1", "value2" };
        }
    }
}
