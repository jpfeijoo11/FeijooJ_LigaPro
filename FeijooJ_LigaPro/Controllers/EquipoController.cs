using System.Numerics;
using FeijooJ_LigaPro.Models;
using FeijooJ_LigaPro.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace FeijooJ_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();

            return View(equipos);
        }
    }
}
