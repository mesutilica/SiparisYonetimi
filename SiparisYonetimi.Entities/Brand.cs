using System;
using System.Collections.Generic;

namespace SiparisYonetimi.Entities
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
