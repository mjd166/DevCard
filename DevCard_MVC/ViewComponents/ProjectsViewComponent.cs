

using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke()
        {

            var projects = new List<Project>
            {
                 new Project(1,"پروژه ی درخواست تاکسی","درخواست انلاین تاکسی برای سفرهای داخل شهری ","project-1.jpg", "اتریا"),
                   new Project(2,"زود فود","درخواست انلاین غذای خیلی سریع  ","project-2.jpg", "اتریا"),
                     new Project(3,"پروژه ی اشیا گمشده","ثبت و جستجو ی اشیا پیدا شده و یا گم شده براساس ادرس و ..  ","project-3.jpg", "مجید"),
                       new Project(4,"پروژه ی مدارس","سیستم مدیریت یک پارچه ی مدارس ","project-4.jpg", "مونوپ")

            };
            return View("_Projects",projects);
        }
    }
}
