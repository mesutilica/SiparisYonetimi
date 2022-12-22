using System;
using System.ComponentModel.DataAnnotations;

namespace SiparisYonetimi.Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "İsim")]
        public string Name { get; set; }
        [Display(Name = "Soyisim")]
        public string Surname { get; set; }
        public string Email { get; set; }
        [Display(Name = "Mesaj")]
        public string Message { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
