
using System.ComponentModel.DataAnnotations;


namespace Liberary_HW_13.Entityes
{
    using RoleEnum;
    using System.Reflection.PortableExecutable;

    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }


        public string UserName { get; set; }

        public string Password { get; set; }
        public RoleEnum RoleEnum { get; set; }

        public List<Book>? Books { get; set; }


        //public DateTime FixedTime { get; set; }

        //public int ReminingDay { get; private set; } = 30;

        //public bool CanBorrow()
        //{
        //    return (DateTime.Now - FixedTime).TotalDays < ReminingDay;
        //}

        //public void ReminingPeriod(int addDays)
        //{
        //    ReminingDay += addDays;
        //}

    }
}
