using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class User
    {
        string login;
        string name;
        string secoundname;
        int age;

        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "name is empty";
                else
                    return name;
            }
        }

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "login is empty";
                return login;
            }
        }

        public string Secoundname
        {
            set { secoundname = value; }
            get
            {
                if (secoundname == null)
                    return "secoundname is empty";
                return secoundname;
            }
        }

        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    Console.Write("age is wrong or not specified. So it is by default = ");
                return age;
            }
        }

        public readonly DateTime date = DateTime.Now;


        public User()
        {
            date = DateTime.Now;
        }

        public User(string login)
        {
            date = DateTime.Now;

            this.login = login;

        }

        public User(string login, string name)
        {
            date = DateTime.Now;

            this.login = login;
            this.name = name;

        }
        public User(string login, string name, string secoundname)
        {
            date = DateTime.Now;

            this.login = login;
            this.name = name;
            this.secoundname = secoundname;

        }
        public User(string login, string name, string secoundname, int age)
        {
            date = DateTime.Now;

            this.login = login;
            this.name = name;
            this.secoundname = secoundname;
            this.age = age;

        }
        public void Show()
        {

            Console.WriteLine(Login);
            Console.WriteLine(Name);
            Console.WriteLine(Secoundname);
            Console.WriteLine(date);
            Console.WriteLine(Age);
            Console.WriteLine(new string('-', 40));
        }

        public void Bring()
        {
            Console.WriteLine(date);
        }

    }
}
