using Application.Services;
using Application.ViewModels;
using CalculadoraPrestamos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraPrestamos.Controllers
{
    public class C_PrestamosController : Controller
    {
        private readonly ILogger<C_PrestamosController> _logger;
        private readonly PrestamoViewModel Pvm = new();
        private readonly PrestamoService Ps = new();
        public C_PrestamosController(ILogger<C_PrestamosController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Pvm);
        }

        [HttpPost]
        public IActionResult Result(PrestamoViewModel Pvm)
        {
            Pvm.resultado = Ps.CalcularPrestamo(Pvm);
            return View(Pvm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
