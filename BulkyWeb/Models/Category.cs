﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [Range(1,int.MaxValue, ErrorMessage ="Please Enter a number 1 or over")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
