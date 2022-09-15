using System;

namespace SiparisYonetimi.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; } // Ürün classı üzerinden ürünün kategori bilgisine entity framework ile ulaşabilmek için
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
