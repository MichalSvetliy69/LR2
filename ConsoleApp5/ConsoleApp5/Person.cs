using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Person
    {
        string name;
        string lastname;
        DateTime birthday;


        public Person()
        {
            name = "Name";
            lastname = "LastName";
            birthday = new DateTime(2010, 10, 10);

        }
        public Person(string name, string lastname, DateTime birthday)
        {
            this.name = name;
            this.lastname = lastname;
            this.birthday = birthday;

        }



        public string Name
        {
            get { return name; }
            set { name = value; }


        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }

        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }

        }

        public int BirthdayYear
        {
            get { return birthday.Year; }
            set
            {
                birthday = new DateTime(value);

            }

        }

        public string ToFullString()
        {
            return name + " " + lastname + " " + birthday.ToString();
        }

        public string ToShortString()
        {
            return name + " " + lastname;
        }


    }
}
