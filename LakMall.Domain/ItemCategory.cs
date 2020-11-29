using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LakMall.Domain
{
  public  class ItemCategory : BaseEntity
    {
        [Required]
        [MaxLength(3,ErrorMessage ="Category Code should be string length of 3.")]
        [Display(Name ="Category Code")]
        public string CategoryCode { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [StringLength(120, ErrorMessage = "Category Name can only contain 120 or less characters.")]
        public string CategoryName { get; set; }

        public string   CategoryType { get; set; }
        public int SortOrder { get; set; }

    }
}
