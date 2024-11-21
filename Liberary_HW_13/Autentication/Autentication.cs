using Liberary_HW_13.Entityes;
using Liberary_HW_13.Repositorys;
using System.Threading.Tasks;
using Liberary_HW_13.RoleEnum;

namespace Liberary_HW_13.Autentication
{
    public class Autentication
    {
        private readonly UserRepository _userRepository;
        public Autentication()
        {
            _userRepository = new UserRepository();
        }
        private User _currentuser;
        public void Register(string firstName,string lastName, string userName, string password,RoleEnum.RoleEnum roleEnum)
        {
            try
            {
                bool isSpecial = password.Any(s => (s >= 33 && s <= 47) || s == 64);

                if (password.Length < 5 || password.Length > 10 || !isSpecial)
                {
                    throw new Exception("Password > 4  Char And One Special Character");
                }


                var user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    UserName = userName,
                    Password = password,
                    RoleEnum = roleEnum,
                    Books = new List<Book>()
                };

                _userRepository.Add(user);
            }
            catch(FormatException ex)
            {
                throw new FormatException($"Error : {ex.Message}");
            }

            catch (Exception ex)
            {
                throw new Exception($"Error : {ex.Message}", ex);
            }
        }
        public void Login(string username, string password)
        {
            try
            {
                var user = _userRepository.GetAll().FirstOrDefault(u => u.UserName == username && u.Password == password);

                if (user == null)
                {
                    throw new Exception("Invalid username or password.");
                }

                _currentuser = user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error : {ex.Message}", ex);

            }
        }
        public User GetCurrentUser()
        {
            return _currentuser;
        }
    }
}
