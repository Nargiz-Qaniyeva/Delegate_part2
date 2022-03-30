using Delegate2.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate2.Models
{
    internal class Library
    {
        public int BookLimit { get; set; }
        private List<Book> _books;
        public Library (int books)
        {
            _books = new List<Book>();
            this._books = _books;
        }
        //public void AddBook(Book books)
        //{
        //    if (books == null)
        //    {
        //        throw new MedicineAlreadyExistsException("Bu obyekt artiq var");
        //    }
        //    if (_MedicineList.Count > MedicineLimit)
        //    {
        //        throw new CapacityLimitException("Limiti kecir");
        //    }
        //}
        public Book GetBookById(int? id)
        {
            if (id == null)
            throw new NullReferenceException("id null olmur");
            Book books = _books.Find(books => books.Id == id && !(books.IsDeleted));

            return books;
        }
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            books.AddRange(_books);

            return books;
        }
        public void DeleteBookById(int? id)
        {
            Book books = _books.Find(books => books .Id == id && books .IsDeleted);
            books.IsDeleted = true;

            if (books  == null)
                throw new NullReferenceException("tapildi");
            _books .Remove(books);

            if (books  != null)
                throw new NotFoundException("Tapilmadi");
        }
        public void EditBookName(int? id)
        {
            
            if (id == null )
            {
                throw new NullReferenceException("Id  null ola bilmir");
            }
            Book books = _books.Find(books => books.Id == id );
            if (books  == null)
            {
                throw new NotFoundException("Book obyekti tapilmadi");
            }
            books.Name = books;
        }
        public List<Book> FilterByPageCount(int minPageCount, int maxPageCount)
        {
            return _books.FindAll(books => books.PageCount >= minPageCount && books.PageCount <= maxPageCount);

        }
    }
}
