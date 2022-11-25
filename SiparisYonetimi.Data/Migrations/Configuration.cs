using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace SiparisYonetimi.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true; // otomatik migration özelliğini aç
            AutomaticMigrationDataLossAllowed = true; // migration işlemlerinde data kayıplarına izin ver
        }

        protected override void Seed(DatabaseContext context)
        {
            // Bu metot veritabanı oluşturulduktan sonra çalışır ve tablolara örnek kayıt ekleyebilmemizi sağlar
            if (!context.Users.Any()) // Eğer veritabanında hiç kayıt yoksa 
            {
                context.Users.Add(new Entities.User // Yeni bir kullanıcı oluştur ve context e ekle
                {
                    CreateDate = DateTime.Now,
                    Email = "admin@SiparisYonetimi.net",
                    Id = 1,
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Surname = "User",
                    Username = "Admin",
                    Password = "123",
                    Phone = "123"
                });
                context.SaveChanges(); // Değişiklikleri veritabanına işle
            }

        }
    }
}
