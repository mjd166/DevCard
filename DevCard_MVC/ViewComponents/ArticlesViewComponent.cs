
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            var articles = new List<Article>
            {
                 new Article(1,"آموزش  Asp.net core MVC","کاملترین پکیج آموزش  Asp.net core mvc ","blog-post-thumb-1.jpg"),

                 new Article(2,"آموزش  Git & github","کاملترین پکیج آموزش  git git hub ","blog-post-thumb-2.jpg"),


                 new Article(3,"آموزش  onion pattern","کاملترین پکیج آموزش  onion pattern ","blog-post-thumb-3.jpg"),

                 new Article(4,"آموزش  مایکروسرویس","کاملترین پکیج آموزش  Micro services ","blog-post-thumb-4.jpg"),
            };
            return View("_Articles",articles);
        }
    }
}
