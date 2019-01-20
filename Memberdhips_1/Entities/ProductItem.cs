using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Memberdhips_1.Entities
{
    [Table("ProductItem")]
    public class ProductItem
    {
        [Required]
        [Key,Column(Order =1)]
        public int ItemId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public int ProductId { get; set; }
        [NotMapped]
        public int OldItemId { get; set; }
        [NotMapped]
        public int OldProductId { get; set; }
    }
}