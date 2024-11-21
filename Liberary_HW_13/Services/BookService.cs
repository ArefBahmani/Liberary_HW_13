using Colors.Net.StringColorExtensions;
using Colors.Net;
using Liberary_HW_13.Entityes;
using Liberary_HW_13.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.Services
{
    public class BookService : BookRepository
    {
        private User _currentuser;
        public bool BorrowedBook(int bookid, int userId)
        {
            var book = Get(bookid);
            if (book == null || book.IsBorrowed)
            {
                return false; 
            }
            book.UserId = userId;
            book.IsBorrowed = true;
            Update(book);
            return true;

        }
        public void ReturnBook(int bookid,int userId)
        {

            var book = Get(bookid);
            book.UserId = null;
           book.IsBorrowed = false;
            Update(book);

        }
        public List<Book> ShowAllBrrowed(int userId)
        {
            var book = GetAll().Where(t => t.UserId == userId  &&  t.IsBorrowed == true);

            return book.ToList();

        }
        public List<Book> AllBooks()
        {
            var book = GetAll();
            
            return book.ToList();
            

        }
        
       
       
    }

}
