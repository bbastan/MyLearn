using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Entities
{
    internal abstract class ILibraryService
    {
        internal abstract void BorrowBook();
        internal abstract void ReturnBook();
        internal abstract void GetListOfLibraryBooks();
        internal abstract void GetListOfUserBooks();
    }
}
