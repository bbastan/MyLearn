using ElectronicLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ElectronicLibrary.Authentication
{
    internal class AuthenticationService : IAuthentication
    {
        private List<User> users = new List<User>(); // لیست کاربران برای سادگی

        public bool Login(string email, string password)
        {
            // جستجوی کاربر با ایمیل و پسورد داده شده
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                // کاربر یافت شد، عملیات لاگین موفقیت‌آمیز
                return true;
            }
            return false;
        }

        public bool Register(string name, string email, string password, int role)
        {
            // بررسی وجود ایمیل تکراری
            if (users.Any(u => u.Email == email))
            {
                return false; // ایمیل تکراری است
            }

            // ایجاد کاربر جدید
            var user = new User { Name = name, Email = email, Password = password, Role = role };
            users.Add(user);
            return true;
        }
    }
}
