using Delegate2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate2.Models
{
    internal class Book: IEntity
    {
        public string  Name { get; set; }
        public string AuthorNamee { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; } = false;
        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}- AuthorNamee:{AuthorNamee}-PageCount:{PageCount}-IsDeleted:{IsDeleted}");
        }
        public Book()
        {
            this.Name = Name;
            this.AuthorNamee = AuthorNamee;
            this.PageCount = PageCount;
        }

        public static implicit operator string(Book v)
        {
            throw new NotImplementedException();
        }
    }
}
