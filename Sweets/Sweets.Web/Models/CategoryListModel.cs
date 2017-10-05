using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Sweets.Web.Models
{
    public class CategoryListModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Введите название категории")]      
        public string Name { get; set; }
        public DateTime DateOfChange { get; set; }
    }
}