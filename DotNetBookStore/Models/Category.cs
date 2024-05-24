﻿using System.ComponentModel.DataAnnotations;

namespace DotNetBookStore.Models
{
    public class Category
    {
        // pk fields should always be called either {Model}Id or just Id
        [Display(Name = "Category ID")]
        [Range(1,999999)]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "A customized error message")]
        public string Name { get; set; }
    }
}
