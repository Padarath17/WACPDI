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
    public class DoctoresController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                var lst = (from d in db.Doctores
                           select d).ToList();
                return Ok(lst);
            }

            // return new string[] { "value1", "value2" };
        }

        //POST
        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.DoctoresRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Doctores oDoctores = new Models.Doctores();
                oDoctores.ApellidoMaterno = model.ApellidoMaterno;
                oDoctores.ApellidoPaterno = model.ApellidoPaterno;
                oDoctores.Correo = model.Correo;
                oDoctores.Estado = model.Estado;
                oDoctores.FechaNacimiento = model.FechaNacimiento;
                oDoctores.Iddoctor = model.Iddoctor;
                oDoctores.Municipio = model.Municipio;
                oDoctores.Nombre = model.Nombre;
                oDoctores.Status = model.Status;
                db.Doctores.Add(oDoctores);
                db.SaveChanges();
            }
            if (ModelState.IsValid)
            {

                return Ok();
            }
            else
                return BadRequest(ModelState);
        }



        //POST
        [HttpPut]
        public ActionResult Put([FromBody] Models.Request.DoctoresRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Doctores oDoctores = db.Doctores.Find(model.Iddoctor);
                oDoctores.ApellidoMaterno = model.ApellidoMaterno;
                oDoctores.ApellidoPaterno = model.ApellidoPaterno;
                oDoctores.Correo = model.Correo;
                oDoctores.Estado = model.Estado;
                oDoctores.FechaNacimiento = model.FechaNacimiento;
                oDoctores.Iddoctor = model.Iddoctor;
                oDoctores.Municipio = model.Municipio;
                oDoctores.Nombre = model.Nombre;
                oDoctores.Status = model.Status;
                db.Entry(oDoctores).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();

        }

        //POST
        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.DoctoresRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Doctores oDoctores = db.Doctores.Find(model.Iddoctor);
                db.Doctores.Remove(oDoctores);
                db.SaveChanges();
            }

            return Ok();

        }

    }

}