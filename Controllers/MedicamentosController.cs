using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WACPDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicamentosController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                var lst = (from m in db.Medicamentos
                           select m).ToList();
                return Ok(lst);
            }

            // return new string[] { "value1", "value2" };
        }

        //POST
        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.MedicamentosRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Medicamentos oMedicamentos = new Models.Medicamentos();
                oMedicamentos.Idmedicamento = model.Idmedicamento;
                oMedicamentos.Nombre = model.Nombre;
                oMedicamentos.Miligramos = model.Miligramos;
                oMedicamentos.FechaCreacion = model.FechaCreacion;
                oMedicamentos.Compuesto = model.Compuesto;
                db.Medicamentos.Add(oMedicamentos);
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
        public ActionResult Put([FromBody] Models.Request.MedicamentosRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Medicamentos oMedicamentos = db.Medicamentos.Find(model.Idmedicamento);
                oMedicamentos.Idmedicamento = model.Idmedicamento;
                oMedicamentos.Nombre = model.Nombre;
                oMedicamentos.Miligramos = model.Miligramos;
                oMedicamentos.FechaCreacion = model.FechaCreacion;
                oMedicamentos.Compuesto = model.Compuesto;
                db.Entry(oMedicamentos).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }

            return Ok();

        }

        //POST
        [HttpDelete]
        public ActionResult Delete([FromBody] Models.Request.MedicamentosRequest model)
        {
            using (Models.CepdiPruebaContext db = new Models.CepdiPruebaContext())
            {
                Models.Medicamentos oMedicamentos = db.Medicamentos.Find(model.Compuesto);
                db.Medicamentos.Remove(oMedicamentos);
                db.SaveChanges();interpo
            }
            delegate
            return Ok();

        }

    }
}
