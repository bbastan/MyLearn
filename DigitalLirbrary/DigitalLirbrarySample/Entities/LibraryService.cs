using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal class LibraryService : ILibraryService
    {

        internal override void BorrowBook()
        {
            //var borrowBook = from borrow in Repository.Repository.books
            //                 where borrow.IsAvailable == false
            //                 select borrow;
            //Console.WriteLine("Numbers greater than 30:");
            //foreach (var borrow in borrowBook)
            //{
            //    Console.WriteLine(borrow);
            //}
        }
        internal override void ReturnBook()
        {

        }
        internal override void GetListOfLibraryBooks()
        {
            var listOfUserBook = from book in Repository.Repository.books
                                 where book.IsAvailable == true
                                 select book;

            Console.WriteLine("Numbers greater than 30:");
            foreach (var list in listOfUserBook)
            {
                Console.WriteLine(list);
            }
        }
        internal override void GetListOfUserBooks()
        {
            var listOfUserBook = from book in Repository.Repository.books
                                 where book.IsAvailable == false
                                 select book;

            Console.WriteLine("Numbers greater than 30:");
            foreach (var list in listOfUserBook)
            {
                Console.WriteLine(list);
            }
        }
    }
}
