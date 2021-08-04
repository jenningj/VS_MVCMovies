using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //Get: Hello World:

        public string Index()
        {
            // https://localhost:5001/HelloWorld.
            return "This is my default action..";
        }

        public string Welcome()
        {
            //https://localhost:5001//HelloWorld/Welcome/
            return "This is the Welcome Action Method";
        }

        public string WelcomeParam(string name, int numTimes = 1)
        {
            //https://localhost:5001//HelloWorld/WelcomeParam/3?name=Rick
            // HelloWorld/WelcomeParam/3?name=Rick&numtimes=4

            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}