using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class AuthorService : BaseService, IService
    {
        AuthorRepository authorRepository;

        public event EventHandler Updated;

        private EventArgs eventArgs = new EventArgs();

        public AuthorService(RepositoryFactory rFactory)
        {
            authorRepository = rFactory.CreateAuthorRepository();
        }

        protected virtual void OnUpdated(object sender, EventArgs eventArgs)
        {
            var handler = Updated;
            if (handler != null)
            {
                handler(this, eventArgs);
                //Testar
            }
        }

        public void Add(Author author)
        {
            authorRepository.Add(author);
            OnUpdated(this, eventArgs);
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        public Author Find(int id)
        {
            return authorRepository.Find(id);
        }

        public void Remove (Author author)
        {
            authorRepository.Remove(author);
            OnUpdated(this, eventArgs);
        }

        public IEnumerable<Book> BookByAuthor (Author author)
        {
            if (IsObjectNotNull(author))
            {
                var books = authorRepository.All().Where(a => a.Id == author.Id).SelectMany(b => b.Books);
                return books;
            }
            throw new ArgumentNullException("No author selected");
                

            
            
        }

    }
}
