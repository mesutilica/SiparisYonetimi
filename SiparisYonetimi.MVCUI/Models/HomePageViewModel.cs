using SiparisYonetimi.Entities;
using System.Collections.Generic;

namespace SiparisYonetimi.MVCUI.Models
{
    public class HomePageViewModel
    {
        public List<Slide> Slides { get; set; }
        public List<Brand> Brands { get; set; }
        public List<Product> Products { get; set; }
    }
}