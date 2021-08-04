using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //Get: Hello World:

        //public string Index()
        //{
            // https://localhost:5001/HelloWorld.
        //    return "This is my default action..";
        //}

        // Replaced the initial public string Index() with the method below:


        public IActionResult Index()
        {
            return View();
        }
        

        public IActionResult Welcome(string name, int numTimes= 1)
        {
            //https://localhost:5001//HelloWorld/Welcome/


            //old method Welcome():
            //return "This is the Welcome Action Method"; 
            // new method using view and paramerts:

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();

        }

        public string WelcomeParam(string name, int numTimes = 1)
        {
            //https://localhost:5001//HelloWorld/WelcomeParam/3?name=Rick
            // HelloWorld/WelcomeParam/3?name=Rick&numtimes=4

            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

        }
        
    }
}