using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Liberary_HW_13.Entityes
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Titel { get; set; }

        [Required]
        public string Discription { get; set; }
        public string Writer { get; set; }
        public int Pages { get; set; }
        public User User { get; set; }
        public DateTime DateTime { get; set; }

        public int? UserId { get; set; }

        
        public bool IsBorrowed { get; set; } = false;



    }
}
