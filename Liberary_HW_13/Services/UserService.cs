using Liberary_HW_13.Entityes;
using Liberary_HW_13.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.Services
{
    public class UserService : UserRepository
    {
        public List<User> AllUser()
        {
            var user = GetAll();
            return user.ToList();
        }
       
    }
}
