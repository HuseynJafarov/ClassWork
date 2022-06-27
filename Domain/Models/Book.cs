using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        //private protected string Name { get; set; }
       //protected internal public string Author { get; set; }

    }
}
