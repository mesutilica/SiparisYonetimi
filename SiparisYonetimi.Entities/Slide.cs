using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class Slide : IEntity
    {
        public int Id { get; set; }
        [StringLength(100), Required]
        public string Image { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(150)]
        public string Link { get; set; }
    }
}
