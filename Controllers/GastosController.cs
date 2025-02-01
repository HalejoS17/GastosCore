using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GastosCore.Data;
using GastosCore.ViewModels;
using System.Linq;

namespace GastosCore.Controllers
{
    public class GastosController : Controller
    {
        private readonly GastosCoreContext _context;

        public GastosController(GastosCoreContext context)
        {
            _context = context;
        }

        public IActionResult Index(DateTime? fechaInicio, DateTime? fechaFin)
        {
            var query = _context.Gastos.Include(g => g.Empleado).ThenInclude(e => e.Departamento).AsQueryable();

            if (fechaInicio.HasValue && fechaFin.HasValue)
            {
                query = query.Where(g => g.Fecha >= fechaInicio && g.Fecha <= fechaFin);
            }

            var gastosPorDepartamento = query
                .GroupBy(g => g.Empleado.Departamento.Nombre)
                .Select(g => new GastoDepartamentoViewModel
                {
                    Departamento = g.Key,
                    TotalGasto = g.Sum(x => x.Monto)
                })
                .ToList();

            return View(gastosPorDepartamento);
        }
    }
}
