using Sweets.DataBaseLogic;
using Sweets.Entities;
using Sweets.Web.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sweets.Web.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            var model = new List<CategoryListModel>();
            using (SweetsContext context = new SweetsContext())
            {
                var categories = context.Categories;
                foreach (Category category in categories)
                {
                    model.Add(new CategoryListModel
                    {
                        Id = category.ID,
                        Name = category.CategoryName
                    });
                }
            }

            return View(model);
        }

        [HttpGet]
        public ViewResult AddCategoryList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategoryList(CategoryListModel categoryList)
        {
            if (ModelState.IsValid)
            {
                var category = new Category();
                category.CategoryName = categoryList.Name;
                category.DateOfChange = DateTime.Now;
                category.Products = null;
                using (SweetsContext context = new SweetsContext())
                {
                    context.Categories.Add(category);
                    //context.SubmitChanges();
                    context.SaveChanges();
                }               
            }

            ViewBag.Sent = "Добавлено";
            var model = new List<CategoryListModel>();
            using (SweetsContext context = new SweetsContext())
            {
                var categories = context.Categories;
                foreach (Category category in categories)
                {
                    model.Add(new CategoryListModel
                    {
                        Id = category.ID,
                        Name = category.CategoryName
                    });
                }
            }
            return PartialView("AdminCategoryList", model);
        }

        [HttpPost]
        public ActionResult ExecuteCommand(int? deleteCategory, int? editCategory)
        {
            SweetsContext context = new SweetsContext();
            if (deleteCategory != null)
            {
                Category currrentCategory = context.Categories.Find(deleteCategory);
                if (currrentCategory != null)
                {
                    context.Categories.Remove(currrentCategory);
                    context.SaveChanges();
                }
            }

            return PartialView("AdminCategoryList");
        }

        [HttpGet]
        public ActionResult OpenPopup(CategoryListModel categoryList)
        {
            //if (ModelState.IsValid)
            //{
            //    AddCategoryList(categoryList);
            //}          
                return PartialView("AddCategory");
            
               
                
        }

    }
}