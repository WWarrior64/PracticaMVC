using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticaMVC.Models;
using PracticaMVC.Servicios;
using System.Diagnostics;

namespace PracticaMVC.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
        private readonly equiposDbContext _context;

        public HomeController(ILogger<HomeController> logger, equiposDbContext context)
		{
			_logger = logger;
			_context = context;
		}

		[Autenticacion]
		public IActionResult Index()
		{
            //Obtengo las variables de sesion
            var tipoUsuario = HttpContext.Session.GetString("TipoUsuario");
			var nombreUsuario = HttpContext.Session.GetString("Nombre");

			//Retorno información a la vista por ViewBag y ViewData
			ViewBag.nombre = nombreUsuario;
			ViewData["tipoUsuario"] = tipoUsuario;
            return View();
		}

		public IActionResult Autenticar()
		{
			ViewData["ErrorMessage"] = "";
			return View();
		}

		[HttpPost]
		public async Task <IActionResult> Autenticar(string txtUsuario, string txtClave) 
		{
            //Valido al usuario con la base de datos
            var usuario = (from u in _context.usuarios
                           where u.email == txtUsuario
                           && u.contrasenia == txtClave
                           && u.activo == "S"
                           && u.bloqueado == "N"
                           select u).FirstOrDefault();

            //Si el usuario existe con todas sus validaciones
            if (usuario != null)
            {
                //Se crean las variables de sesión
                HttpContext.Session.SetInt32("UsuarioId", usuario.id_usuario);
                HttpContext.Session.SetString("TipoUsuario", usuario.tipo_usuario);
                HttpContext.Session.SetString("Nombre", usuario.nombre);

                //Se redirecciona al método de Index del controlador Home
                return RedirectToAction("Index", "Home");
            }

            ViewData["ErrorMessage"] = "";
			return View(); 
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Logout()
		{
			HttpContext.Session.Clear();
			return RedirectToAction("Index");
		}
	}
}
