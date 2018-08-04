using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PasswordAfterMailConfirmation.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Review { get; set; }
        public string Other { get; set; }
        public string Remarks { get; set; }
    }
}