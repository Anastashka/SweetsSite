using Sweets.Entities;
using Sweets.Web.Models;
using Sweets.DataBaseLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sweets.Web.Controllers
{
    public class CategoryListController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult AddCategoryList()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddCategoryList(CategoryListModel categoryList)
        {
            if (ModelState.IsValid)
            {
                var category = new Category();
            category.CategoryName = categoryList.Name;
            category.DateOfChange = DateTime.Now;
           using (SweetsContext context = new SweetsContext())
           {
                context.Categories.Add(category);
                context.SaveChanges();
           }

                return View("Категория добавлена", categoryList);
            }
            else
                
                return View();
        }
    }
}