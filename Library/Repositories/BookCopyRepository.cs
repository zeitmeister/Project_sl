using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        public BookCopyRepository(LibraryContext c)
        {
            context = c;
        }

        /// <summary>
        /// Adds a book copy to the database
        /// </summary>
        /// <param name="item"></param>
        public void Add(BookCopy item)
        {
            context.BookCopies.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Returns all the bookcopies from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        /// <summary>
        /// Edits a book copy
        /// </summary>
        /// <param name="item"></param>
        public void Edit(BookCopy item)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public BookCopy Find(int id)
        {
            return context.BookCopies.Where(cb => cb.Id == id) as BookCopy;
        }

        /// <summary>
        /// Deletes a book copy from the database
        /// </summary>
        /// <param name="item"></param>
        public void Remove(BookCopy item)
        {
            context.BookCopies.Remove(item);
            /*try
            {*/
                context.SaveChanges();
            /*} catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            
        }
    }
}
