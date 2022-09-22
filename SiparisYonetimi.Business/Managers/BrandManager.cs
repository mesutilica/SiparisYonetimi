using SiparisYonetimi.Business.Repositories;
using SiparisYonetimi.Entities;

namespace SiparisYonetimi.Business.Managers
{
    public class BrandManager : Repository<Brand> // Repository classından miras aldık böylece içindeki tüm metotları Brand class ı için kullanabileceğiz
    {
        // Burada markaya özel metotlar yazılabilir, örneğin markaya ait ürünleri listeleyen metot gibi
    }
}
