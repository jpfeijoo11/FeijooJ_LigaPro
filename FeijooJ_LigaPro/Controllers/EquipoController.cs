using System.Numerics;
using FeijooJ_LigaPro.Models;
using FeijooJ_LigaPro.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace FeijooJ_LigaPro.Controllers;

public class EquipoController : Controller
{
    public EquipoRepository _repository;

    public EquipoController()
    {
        _repository = new EquipoRepository();
    }
    public IActionResult List()
    {
        
        var equipos = _repository.DevuelveListadoEquipos();

        return View(equipos);
    }
    public IActionResult EditarEquipo(int Id)
    {
        
        var equipo = _repository.DevuelveInformacionEquipo(Id);
        return View(equipo);
    }
    [HttpPost]
    public IActionResult EditarEquipo(Equipo equipo)
    {
        try
        {
            
            return View();
        }
        catch (Exception ex)
        {
            throw;

        }
    }
}
