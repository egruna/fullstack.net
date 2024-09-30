using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_ThisKeyword
{
    public class person
    {

        public string Firstname;
        public string Lastname;

        public person(string firstname, string lastname)
        {
            // منظور از this  ارجاع به کلاس بالاسر است
            this.Firstname = firstname;
            this.Lastname = lastname;
        }

        public void rename(string newName)
        {
            Firstname = newName;
            PersonPrinter Printer = new PersonPrinter();
            // پاس دادن اینستنس جاری کلاس
            Printer.Print(this);
        }
    }

    public class PersonPrinter
    {
        public void Print(person person) 
        {
            Console.WriteLine($"FirstN Name:{person.Firstname} , Last Name :  {person.Lastname}");
        }
    }
}
