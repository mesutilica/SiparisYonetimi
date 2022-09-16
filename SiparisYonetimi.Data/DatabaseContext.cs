using SiparisYonetimi.Entities;
using System.Data.Entity; // Bu kütüphane entity framework paketinden geliyor

namespace SiparisYonetimi.Data
{
    public class DatabaseContext : DbContext // Burada Entity frameworkün DbContext sınıfından miras alıyoruz DatabaseContext sınıfında dbcontext leri kullanabilmek için
    {
        public DatabaseContext()
        {

        }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
/*
 * Proje yaparken classları ve database context i kurduktan sonra veritabanını otomatik oluşturtmak yerine migrationla oluşturmamız gerekir.
 * Migration u aktif etmek için Visual studio da en üst menüden Tools > Nuget Pack... Manager > Package manage console menüsünü aktif ediyoruz. Aşağıdaki Pmc alanını açıyoruz
 * Önce Default Project bölümünden database context imizin bulunduğu Data katmanını seçiyoruz
 * Sonra aşağıdaki kod alanına Enable-migrations yazıp enter a basarak Initialcreate class ının oluşturulmasını sağlıyoruz.
 * Oluşan Configuration sınıfının içerisinde başlangıç verisi oluşturabileceğimiz Seed metodu oluşuyor bunu kullanarak veritabanı oluştuktan sonra örnek data oluşturabiliriz.
 * Eğer enable-migrations tan sonra initial create class ı oluşmazsa P.M.C komut ekranına add-migration InitialCreate yazıp enter a basarak kendimiz oluşturabiliriz.
 * 
 */