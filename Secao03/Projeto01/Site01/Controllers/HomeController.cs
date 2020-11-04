using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site01.Models;

namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return new ContentResult() { Content = "Teste123.....", ContentType = "text/plain" };

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                if (usuario.Email == "ademirt@gmail.com" && usuario.Senha == "123")
                {
                    //adiciona sessão...
                    /*HttpContext.Session.SetString("Login", "true");
                    HttpContext.Session.SetInt32("UserID",32);

                    //ler sessão...
                    string login = HttpContext.Session.GetString("Login");
                    */
                    HttpContext.Session.SetString("Login", "true");

                    return RedirectToAction("Index","Palavra");
                }
                else
                {
                    ViewBag.Mensagem = "Dados informados inválidos!!!";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            //limpar todas sessões que estiver no servidor
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}
