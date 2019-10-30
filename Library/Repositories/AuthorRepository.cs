using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        public AuthorRepository(LibraryContext c)
        {
            context = c;
        }

        /// <summary>
        /// Adds item to the database
        /// </summary>
        /// <param name="item"></param>
        public void Add(Author item)
        {
            context.Authors.Add(item);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all auhtors from the database
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        public void Edit(Author item)
        {
            context.SaveChanges();
        }

        /// <summary>
        /// Finds a specific Author from the database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Author Find(int id)
        {
            return context.Authors.Where(a => a.Id == id) as Author;
        }

        /// <summary>
        /// Deletes a author from the database
        /// </summary>
        /// <param name="item"></param>
        public void Remove(Author item)
        {
            context.Authors.Remove(item);
            context.SaveChanges();
        }
    }
}
