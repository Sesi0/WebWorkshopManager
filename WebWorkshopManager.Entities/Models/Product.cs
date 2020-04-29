using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Entities.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public PRODUCT_TYPE ProductType { get; set; }

        [Required]
        public decimal QuantityInStock { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
    }
}
