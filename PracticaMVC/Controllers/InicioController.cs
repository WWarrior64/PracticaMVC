using Microsoft.AspNetCore.Mvc;
using PracticaMVC.Models;
using PracticaMVC.Services;

namespace PracticaMVC.Controllers
{
    public class InicioController : Controller
    {
        private readonly equiposDbContext _context;

        private IConfiguration _configuration;

        public InicioController (equiposDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            correo enviarCorreo = new correo(_configuration);

            enviarCorreo.enviar("walter.gonzalez3@catolica.edu.sv",
                                "Prueba Asunto",
                                "Esta es una prueba de correo desde ASP.Net");
            return View();
        }
    }
}
