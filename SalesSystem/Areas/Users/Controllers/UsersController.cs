using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace SalesSystem.Areas.Users.Controllers
{
    [Area("Users")]
    public class UsersController : Controller
    {

        public IActionResult Users()
        {
            //La forma de acceder a los metodos del controlador en la url es /nombreController/nombreMetodo?parametros
            // https://localhost:7099/Users/Users?area=Users este sería un ejemplo lo que va despupes del ? es para indicar que el area que se usa es el llamado Users
            return View();
        }
    }
}
