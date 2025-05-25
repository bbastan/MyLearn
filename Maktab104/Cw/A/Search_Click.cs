using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoginRegisterUser
{
    public class Search_Click : Authentication
    {
        public static string SearchButton_Click(string sender)
        {
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\b.bastan\\Maktab Sharif\\Test\\Database.txt");
            string fileRead;

            fileRead = file.ReadToEnd();
            if (fileRead.Contains(sender))
            {
                return sender;
            }
            else
            {
                File.AppendAllText(fileLog, DateTime.Now.ToString());
                File.AppendAllText(fileLog, $" :{sender}:Not Found\n");
                throw new Exception("Not Found Email or Password");
            }
            //while ((fileRead = file.ReadToEnd()) != null)
            //{
            //    if (fileRead.Contains(sender))
            //    {
            //        return sender;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
        }
    }
}
