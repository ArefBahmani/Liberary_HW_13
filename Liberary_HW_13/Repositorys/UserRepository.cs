using Liberary_HW_13.Entityes;
using Liberary_HW_13.InterFaces;
using Microsoft.EntityFrameworkCore;

namespace Liberary_HW_13.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository()
        {
            _appDbContext = new AppDbContext();

            _appDbContext.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public void Add(User user)
        {
            
            _appDbContext.Users.Add(user);
            
            _appDbContext.ChangeTracker.DetectChanges();
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            
            var user = Get(id);

            if (user != null)
            {
                
                _appDbContext.Entry(user).State = EntityState.Deleted;

                
                _appDbContext.ChangeTracker.DetectChanges();
                _appDbContext.SaveChanges();
            }
        }

        public User Get(int id)
        {
            
            return _appDbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAll()
        {
            
            return _appDbContext.Users.AsNoTracking().ToList();
        }

        public void Update(User user)
        {
            
            var existUser = _appDbContext.Users.AsNoTracking().FirstOrDefault(u => u.Id == user.Id);

            if (existUser != null)
            {
                existUser.FirstName = user.FirstName;
                existUser.LastName = user.LastName;
                existUser.UserName = user.UserName;
                existUser.Password = user.Password;

                _appDbContext.Entry(user).State = EntityState.Modified;

               
                _appDbContext.ChangeTracker.DetectChanges();
                _appDbContext.SaveChanges();
            }
        }
    }

}

