using Liberary_HW_13.Entityes;
using Liberary_HW_13.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.Repositorys
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;


        public BookRepository()
        {
            _appDbContext = new AppDbContext();

            _appDbContext.ChangeTracker.AutoDetectChangesEnabled = false;
        }

        
        public void AddBook(string titel,string desc,string writer,int page)
        {
            var boook = new Book
            {
                Titel = titel,
                Discription = desc,
                Writer = writer,
                Pages = page

            };
            _appDbContext.Books.Add(boook);

            _appDbContext.SaveChanges();
        }

        
        public void Delete(int id)
        {
            var book = Get(id); 

            if (book != null)
            {
                
                _appDbContext.Entry(book).State = EntityState.Deleted;
                
                _appDbContext.ChangeTracker.DetectChanges();
                _appDbContext.SaveChanges();
            }
        }

        
        public Book Get(int id)
        {
            
            return _appDbContext.Books.AsNoTracking().FirstOrDefault(b => b.Id == id);
        }

        
        public List<Book> GetAll()
        {
            
            return _appDbContext.Books.AsNoTracking().ToList();
        }

        
        public void Update( Book book)
        {
            _appDbContext.Update(book);
            _appDbContext.SaveChanges();
        }
    }
}
