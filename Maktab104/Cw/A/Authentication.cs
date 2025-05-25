using LoginRegisterUser;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoginRegisterUser
{
    public class Authentication : Person
    {
        //internal static string? writeText;
        public static readonly string fileLog = "C:\\Users\\b.bastan\\Maktab Sharif\\Test\\log.txt";
        public static readonly string fileDatabase = "C:\\Users\\b.bastan\\Maktab Sharif\\Test\\database.txt";

        public void Register()//string? firstName, string? lastName, int? age, int? gender, string? cellPhone, string? city, string? address, string? email, string? password)
        {
            var contacts = new ContactInfo();
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Register\n");
            File.AppendAllText(fileDatabase, " ******************************\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, " : New Register\n");

            Console.Write("*Firstname: ");
            Name = Console.ReadLine();
            if (Name == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Firstname is mandatory and cannot be null, Please fill out it\n");
                throw new ArgumentNullException("Firstname is mandatory");
            }
            else if ((Name.Contains("1")) || (Name.Contains("2")) || (Name.Contains("3")) || (Name.Contains("4")) || (Name.Contains("5")) || (Name.Contains("6")) || (Name.Contains("7")) || (Name.Contains("8")) || (Name.Contains("9")) || (Name.Contains("0")))
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Firstname is mandatory and cannot begin with number, Please fill out it with correct value\n");
                throw new ArgumentOutOfRangeException("Firstname is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : First Name: {Name}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : First Name: {Name}\n");

            Console.Write("*Lirstname: ");
            Family = Console.ReadLine();
            if ((Family.Contains("1")) || (Family.Contains("2")) || (Family.Contains("3")) || (Family.Contains("4")) || (Family.Contains("5")) || (Family.Contains("6")) || (Family.Contains("7")) || (Family.Contains("8")) || (Family.Contains("9")) || (Family.Contains("0")))
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Lastname is mandatory and should not be begin to number, Please fill out it with correct value\n");
                throw new ArgumentOutOfRangeException("Lastname is mandatory");
            }
            else if (Family == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Lastname is mandatory and cannot be NULL, Please fill out it\n");
                throw new ArgumentNullException("Lastname is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Last Name: {Family}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Last Name: {Family}\n");

            Console.Write("*Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            if (Age == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Age is mandatory and cannot be NULL\n");
                throw new ArgumentOutOfRangeException("Age is mandatory");
            }
            else if (Age < 18)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Age is mandatory and should be +18\n");
                throw new ArgumentOutOfRangeException("Age is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Age: {Age}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Age: {Age}\n");

            Console.Write("*Gender (1 is Mela, 2 is Female): ");
            Gender = (Gender)Convert.ToUInt32(Console.ReadLine());
            if (Gender is (Gender)1 or (Gender)2)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Gender: {Gender}\n");
                File.AppendAllText(fileDatabase, DateTime.Now.ToString());
                File.AppendAllText(fileDatabase, $" : Gender: {Gender}\n");
            }
            else
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Gender is mandatory and Male-> point 1 or Female-> point 2, Please fill out it with correct value\n");
                throw new ArgumentOutOfRangeException("Gender is mandatory");
            }

            Console.Write("*Cellphone: ");
            contacts.CellPhone = Console.ReadLine();
            if (contacts.CellPhone == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : CellPhone cannot empty, Please fill out it with correct value\n");
                throw new Exception("CellPhone is mandatory");
            }
            else if (contacts.CellPhone.Length < 11)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : CellPhone cannot loser 11 number, Please fill out it with correct value\n");
                throw new Exception("CellPhone is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : CellPhone: {contacts.CellPhone}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Cell Phone: {contacts.CellPhone}\n");

            Console.Write("*Email: ");
            contacts.Email = Console.ReadLine();
            if (contacts.Email == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Email is mandatory and cannot be NULL\n");
                throw new ArgumentNullException("Email is mandatory");
            }
            else if (!contacts.Email.Contains('@'))
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Email is mandatory and must be include @");
                throw new ArgumentNullException("Email is mandatory");
            }
            else if (!contacts.Email.Contains('.'))
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Email is mandatory and must be include .");
                throw new ArgumentNullException("Email is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Email: {contacts.Email}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Email: {contacts.Email}\n");

            Console.Write("*Password: ");
            contacts.Password = Console.ReadLine();
            if (contacts.Password == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Password is mandatory and cannot be NULL");
                throw new ArgumentNullException("Password is mandatory");
            }
            else if (contacts.Password.Length < 8)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, " : Password is mandatory and should be 8 character");
                throw new ArgumentNullException("Password is mandatory");
            }
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Password: {contacts.Password}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Password: {contacts.Password}\n");

            Console.Write("City: ");
            contacts.City = Console.ReadLine();
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : City: {contacts.City}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : City: {contacts.City}\n");

            Console.Write("Address: ");
            contacts.Address = Console.ReadLine();
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Address: {contacts.Address}\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, $" : Address: {contacts.Address}\n");

            Console.WriteLine("User successfully registered.");
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, " : User successfully registered\n");
            File.AppendAllText(fileLog, " ******************************\n");
            File.AppendAllText(fileDatabase, DateTime.Now.ToString());
            File.AppendAllText(fileDatabase, " : User successfully registered\n");
            //File.AppendAllText(fileDatabase, " ******************************\n");
        }
        public void Login()
        {
            var contacts = new ContactInfo();
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Login\n");

            Console.Write("*Email: ");
            contacts.Email = Console.ReadLine();
            string foundSearch = Search_Click.SearchButton_Click(contacts.Email);
            if (contacts.Email == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Email:{contacts.Email},Error:Email is mandatory and cannot be null\n");
                throw new ArgumentNullException("Email is mandatory  and cannot be null, Please fill out it.");
            }
            else if (!contacts.Email.Contains('@') || (!contacts.Email.Contains('.')))
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Email:{contacts.Email},Error:Email should be include @ and dot\n");
                throw new ArgumentNullException("Email should be include @ and dot, Please fill out it.");
            }
            else if (contacts.Email == foundSearch)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Email: {contacts.Email}\n");
            }

            Console.Write("*Password: ");
            contacts.Password = Console.ReadLine();
            string foundSearchPassword = Search_Click.SearchButton_Click(contacts.Password);
            if (contacts.Password == null)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Password:{contacts.Password},Error:Password is mandatory and cannot be null\n");
                throw new ArgumentNullException("Password is mandatory");
            }
            else if (contacts.Password.Length < 8)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Password:{contacts.Password},Error:Password should be 8 character\n");
                throw new ArgumentOutOfRangeException("Password is mandatory");
            }
            else if (contacts.Password == foundSearchPassword)
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" : Password: {contacts.Password}\n");
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                Console.WriteLine("You have successfully logged in.");
                File.AppendAllText(fileLog, " : You have successfully logged in\n");
            }
            
        }
        public void ExitProgram()
        {
            File.AppendAllText(fileLog, DateTime.Now.ToString());
            File.AppendAllText(fileLog, $" : Program Exit\n");
            System.Environment.Exit(0);
        }
    }
}


