using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_ADV
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(",", Authors)}, Publication Date: {PublicationDate}, Price: {Price}";
        }

        public class BookFunctions
        {
            public static string GetTitle(Book B)
            {
                return B.Title;
            }

            public static string[] GetAuthors(Book B)
            {
                return B.Authors;
            }

            public static decimal GetPrice(Book B)
            {
                return B.Price;
            }
        }
    }
}
