using Liberary_HW_13.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.InterFaces
{
    public interface IBookRepository
    {
        public void AddBook(string titel, string desc, string writer, int page);
        public List<Book> GetAll();
        public Book Get(int id);
        public void Delete(int id);
        public void Update(Book book);

    }
}
