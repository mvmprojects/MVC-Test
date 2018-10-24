using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        // Because you didn't explicitly specify the name of the view template file, 
        // MVC defaulted to using the Index.cshtml view file in the /Views/HelloWorld folder.
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        // Requires using System.Text.Encodings.Web;
        //public string Welcome(string name, int numTimes = 1)
        //{
        //   return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //    // HtmlEncoder.Default.Encode protects against malicious input
        //} // test with localhost:44330/HelloWorld/Welcome?name=Rick&numtimes=4

        // we use the URL segment */*/Parameters/ in the next test
        //public string Welcome(string name, int ID = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"HI {name}, ID: {ID}");
        //} // test with localhost:44330/HelloWorld/Welcome/3?name=Rick
          // "ID" matches the (optional) third route param in template: "{controller=Home}/{action=Index}/{id?}");
          // note: in non-debug mode, you don't have to rebuild the app to see changes in these interpolated strings.
          // just save this file, and refresh in your browser.

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}