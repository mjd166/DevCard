using Microsoft.AspNetCore.Mvc;


namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}


        //public PartialViewResult Index()
        //{
        //    return PartialView("Footer");
        //}


        //public IActionResult Index()
        //{
        //    return View("Footer");
        //}




        ////return context result
        ///

        //public ContentResult Index()
        //{
        //    //return Content("<h1>Hello asp.net core mvc this majid ghafari</h1>");
        //    return Content("<h1 style='color:red'>Hello asp.net core mvc this majid ghafari </h1>","text/html");
        //}

        /// return empty result or null example ... 
        //public EmptyResult Index()
        //{
        //    return new EmptyResult();   // == return null;
        //}



        ////////////////////////////////////////////////
        ///
        ///return fileresult example 
        ///

        //public FileResult Index()
        //{
        //    /// return File("~/Test.txt", "text/html");  /// return content of file as text 
        //    /// 
        //    var filebyte = System.IO.File.ReadAllBytes("wwwroot/Test.txt");
        //    const string filename = "testfile.txt";   //name of the file after the download on client.

        //    return File(filebyte, System.Net.Mime.MediaTypeNames.Text.Plain,filename);
        //}





        ///json result & javascript result
        ///
        //public JsonResult Index()
        //{
        //    return Json(new { id = 1, Name = "hossein", job = "programmer", site = "Atria.com " });
        //}

        //public JavaScriptResult Index()
        //{
        //    return new JavaScriptResult("alert('salam salam salam hamegi salam ')");
        //}



        ////////////// return redirect samples 
        ///
        //public RedirectResult Index()
        //{
        //    return Redirect("http://www.atria.com");
        //}

        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}



        ///
        //
        //example to httpstatus codes 

        public IActionResult Index()
        {
            //return new OkResult();
            //return new NotFoundResult();

            //  return new BadRequestResult();

            // return new NoContentResult();

            //return new StatusCodeResult(896);

            //   return new StatusCodeResult(510);


            return new UnauthorizedResult();
        }

    }

    //public class JavaScriptResult : ContentResult
    //{
    //    public JavaScriptResult(string data) 
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }
    //}
}
