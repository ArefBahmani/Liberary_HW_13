using Liberary_HW_13.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.InterFaces
{
    public interface IUserRepository
    {
        public void Add(User user);
        public List<User> GetAll();
        public User Get(int id);
        public void Update(User user);
        public void Delete(int id);
    }
}
