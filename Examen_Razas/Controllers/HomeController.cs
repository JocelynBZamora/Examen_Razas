using Examen_Razas.Models;
using Examen_Razas.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Examen_Razas.Controllers
{
    public class HomeController : Controller
    {

        PerrosContext context =new();
        public IActionResult Index()
        {
            var vm = context.Razas.OrderBy(x=>x.Nombre).
                Select(x=> new InfoPerroViewModel { Id = (int)x.Id,Name= x.Nombre ?? "no contiene nombre"}).ToList();
            return View(vm);
        }

        [Route("/InfoPerro/{nombre}")]
        public IActionResult InfoPerro(string nombre)
        {
            nombre = nombre.Replace("_", " ");
            var vm = context.Razas.OrderBy(x => x.Nombre).Where(x => x.Nombre == nombre).
                Select(x => new InfoPerroViewModel { 
                    Id = (int)x.Id , 
                    Name = x.Nombre ?? "no contiene nombre",
                    OtroNombre = x.OtrosNombres ?? "no contiene otro nombre",
                    AlruraMax = (int)x.AlturaMax,
                    AlruraMin = (int)x.AlturaMin,
                    PesoMin = (int)x.PesoMin,
                    PesoMax = (int)x.PesoMax,
                    EsperanzaVida =(int) x.EsperanzaVida,
                    Pais = x.PaisOrigen,
                    Descripcion = x.Descripcion ?? "no cuenta con descripcion alguna"
                    
                }).FirstOrDefault();
            return View(vm);
        }
    }
}
