using SiparisYonetimi.Data;
using SiparisYonetimi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisYonetimi.Business.Managers
{
    public class UserManager
    {
        DatabaseContext context = new DatabaseContext();
        public List<User> GetAll()
        {
            return context.Users.ToList();
        }
    }
}
