using Lab5_interfejs.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_interfejs.Models
{
    class Book : IEntity<int>, IHasCreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }
    }
}
