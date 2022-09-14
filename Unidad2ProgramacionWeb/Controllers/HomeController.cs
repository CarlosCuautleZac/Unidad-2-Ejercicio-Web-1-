using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Unidad2ProgramacionWeb.Models;

namespace Unidad2ProgramacionWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MexicoContext context = new();

            var estados = context.Estados.OrderBy(x =>x.Nombre);



            return View(estados);
        }
    }
}
