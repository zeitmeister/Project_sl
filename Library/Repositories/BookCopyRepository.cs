﻿using Library.Models;
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
        public void Add(BookCopy item)
        {
            context.BookCopies.Add(item);
            context.SaveChanges();
        }

        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        public IEnumerable<BookCopy> SpecificBookCopies(Book book)
        {
            return context.BookCopies.Where(bc => bc.Book.Id == book.Id);
        }

        public void Edit(BookCopy item)
        {
            context.SaveChanges();
        }

        public BookCopy Find(int id)
        {
            return context.BookCopies.Where(cb => cb.Id == id) as BookCopy;
        }

        public void Remove(BookCopy item)
        {
            context.BookCopies.Remove(item);
            try
            {
                context.SaveChanges();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
