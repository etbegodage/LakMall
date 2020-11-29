using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LakMall.Domain
{
   public class BaseEntity
    {

        [Key]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }
        [ScaffoldColumn(false)]
        public DateTime LastModified { get; set; }
        [ScaffoldColumn(false)]
        public int CreatedById { get; set; }
        [ScaffoldColumn(false)]
        public int ModifiedById { get; set; }
        [ScaffoldColumn(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
