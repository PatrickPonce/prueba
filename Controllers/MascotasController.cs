using Microsoft.AspNetCore.Mvc;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class MascotasController : Controller
    {
        // GET: Mostrar formulario
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Procesar formulario
        [HttpPost]
        public IActionResult Crear(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                // Aquí podrías guardar en base de datos o lista en memoria
                // Por ejemplo: _context.Add(mascota); await _context.SaveChanges();
                return RedirectToAction("Confirmacion", mascota);
            }
            return View(mascota);
        }

        public IActionResult Confirmacion(Mascota mascota)
        {
            return View(mascota);
        }
    }
}
