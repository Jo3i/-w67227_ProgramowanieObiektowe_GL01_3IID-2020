using Lab5_interfejs.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_interfejs.Models
{
    class Person : IEntity<int>, IHasCreationTime
    {
        public int Id { get; set;}
        public DateTime CreationTime { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int age { get; set;}
        public List<Book> BorrowedBook { get; set; } = new List<Book>();
    }
}
