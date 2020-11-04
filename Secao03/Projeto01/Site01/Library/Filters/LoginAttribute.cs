using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Site01.Library.Filters
{
    public class LoginAttribute : ActionFilterAttribute
    {
        //tratar a requisão por filtro...
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //verificar se a sessão existe...
            if (context.HttpContext.Session.GetString("Login") == null)
            {
                if (context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "É necessário logar!!!";
                }

                //redirecionar...
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
