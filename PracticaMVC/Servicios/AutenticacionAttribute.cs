using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PracticaMVC.Servicios
{
    public class AutenticacionAttribute : ActionFilterAttribute
    {
        //Este método se ejecuta antes de que se ejecute la accion del controlador.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Verificar si la variable de sesión 'UsuarioId' existe
            var usuarioId = context.HttpContext.Session.GetInt32("UsuarioId");

            if (usuarioId == null)
            {
                //Si no está autenticado, redirigir a la pagina de login
                context.Result = new RedirectToActionResult("Autenticar", "Home", null);
            }

            base.OnActionExecuting(context);
        }
    }
}
