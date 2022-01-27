using Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DAP.Plantilla.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "PAGINA DE INFORMACION GENERAL .";

            return View();
        }




        [HttpGet]
        public ActionResult verVistaParcial()
        {
            var materiasObtenidas = HomeNegocios.ObtenerMaterias_Ejemplo();

            Dictionary<int, string> seleccionarMaterias = new Dictionary<int, string>();
            if (materiasObtenidas.Count >0) 
            {
                foreach(var nuevaMateriaLeida in materiasObtenidas) 
                {

                    seleccionarMaterias.Add(nuevaMateriaLeida.Id, nuevaMateriaLeida.NombreMateria);
                }

                ViewBag.NombreVariable = materiasObtenidas;
            }

            return PartialView(seleccionarMaterias);
        }



        [HttpPost]
        public ActionResult ObtenerAlumnos(int IdMateria)
        {
            var dto = HomeNegocios.ObtenerAlumnosIdMateria(IdMateria);

            return Json (new {ListaEjemplo = dto }, JsonRequestBehavior.AllowGet);
        }




        public ActionResult ObtenerEspecialidadIdMateria(int IdMateria)
        {
            var dto = HomeNegocios.ObtenerEspecialidad(IdMateria);

            return Json(new { ListaEjemplo = dto }, JsonRequestBehavior.AllowGet);
        }








        /************************************************************************************************************************************************************************/
        /********************************************************* Ejemplo Peticion axios  *************************************************************************************/

        public ActionResult RealizarUnaAccion()
        {


            return Json(new { VariableKey = "Hola se ejecuto algo en el servidor" }, JsonRequestBehavior.AllowGet);
        }





    }
}