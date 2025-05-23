using DigitalLirbrarySample.Entities;
using DigitalLirbrarySample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLirbrarySample.Repository
{
    internal static class Repository
    {
        internal static List<Member> members = new List<Member>
        {
            new Member {Id = 100,FullName = "Babak Bastan",Age = 40,RoleUser = Role.Member, EducateUser = Educate.Master, Borrow=1},
            new Member {Id = 101,FullName = "Amir Pasha",Age = 37,RoleUser = Role.Member, EducateUser = Educate.Bachelor, Borrow=1},
            new Member {Id = 102,FullName = "Reza Arghand",Age = 60,RoleUser = Role.Member, EducateUser = Educate.Phd, Borrow=0},
            new Member {Id = 103,FullName = "Mostafa Nouri",Age = 39,RoleUser = Role.Member, EducateUser = Educate.Bachelor, Borrow = 2},
            new Member {Id = 104,FullName = "Peyman Mehrabani",Age = 35,RoleUser = Role.Member, EducateUser = Educate.Bachelor, Borrow = 0}
        };
        internal static List<Librarian> librarians = new List<Librarian>
        {
            new Librarian {Id = 1,FullName = "Ahmad Ahmadi",Age = 60,RoleUser = Role.Librarian },
            new Librarian {Id = 2,FullName = "Masoud Pezeshkian",Age = 70,RoleUser = Role.Librarian }
        };
        internal static List<Book> books = new List<Book>
        {
            new Book {Id = 1000,Auther="Zhoze",CategoryBook=Categories.Adabiyat,IsAvailable=false,Title="kori" },
            new Book {Id = 1001,Auther="Jodi",CategoryBook=Categories.Falsafeh,IsAvailable=true,Title="Nameha" },
            new Book {Id = 1002,Auther="Nicson",CategoryBook=Categories.Honar,IsAvailable=false,Title="ninaei" },
            new Book {Id = 1003,Auther="Sorosh",CategoryBook=Categories.Roman,IsAvailable=true,Title="rohe khoda" },
            new Book {Id = 1004,Auther="Khoze",CategoryBook=Categories.Tarikhi,IsAvailable=false,Title="Iran" },
            new Book {Id = 1005,Auther="Joliya",CategoryBook=Categories.Roman,IsAvailable=true,Title="Bikhiali" },
            new Book {Id = 1006,Auther="Nilson",CategoryBook=Categories.Adabiyat,IsAvailable=false,Title="bidari" },
            new Book {Id = 1007,Auther="Dolatabadi",CategoryBook=Categories.Honar,IsAvailable=true,Title="khoda" }
        };

    }

}
