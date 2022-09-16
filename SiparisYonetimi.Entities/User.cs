using System;
using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)] // Veritabanında oluşan kolonun nvarcharmax yerine nvarchar(50) olması için
        public string Name { get; set; }
        [StringLength(50)]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
