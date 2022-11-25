using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        [StringLength(100), Required]
        public string Name { get; set; }
        [StringLength(100)]
        public string Logo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public virtual List<Product> Products { get; set; }
        public Brand()
        {
            Products = new List<Product>();
        }
    }
}
