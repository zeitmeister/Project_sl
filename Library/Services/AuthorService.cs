using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    class AuthorService : IService
    {
        AuthorRepository authorRepository;

        public event EventHandler Updated;

        public AuthorService(RepositoryFactory rFactory)
        {
            authorRepository = rFactory.CreateAuthorRepository();
        }

        public void Add(Author author)
        {
            authorRepository.Add(author);
        }

        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }
    }
}
