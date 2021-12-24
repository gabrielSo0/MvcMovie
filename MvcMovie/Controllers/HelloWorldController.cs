using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Cada método público na controller é chamado de HTTP Endpoint, ou seja, uma URI diferente.

        // GET: /HelloWorld/ the index is HelloWorld and returns a View
        // IActionResult é o tipo que o método retorna, nesse caso, retorna qualquer tipo de dado.
        public IActionResult Index()
        {
            return View();
        }
        // GET: /HelloWorld/Welcome/ the name of the method determinate the path URI
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
