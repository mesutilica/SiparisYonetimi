using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [StringLength(100), Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public virtual List<Product> Products { get; set; } // Kategori ile Product arasında ilişki kurduk. 1 Kategoriye ait birden fazla Product olabileceği için List ile bire çok ilişki kurduk
        public Category() // Kısayolu ctor tab tab
        {
            Products = new List<Product>();
        }
    }
}
