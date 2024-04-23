using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VISA_PERMISSION_FORM_APP
{
    internal class Person
    {
        public string NameSurname { get; set; }
        public bool IsAlive { get; set; }

        public Person()
        {
            IsAlive = true;
        }
        public Person(string name_surname)
        {
            NameSurname = name_surname;
            IsAlive = true;
        }
        public static string Greetings() //the reason why we used static keyword is using this method by no creating any object
        {
            return "Welcome to the Visa Permission System!";
        }
        public string showUserName()
        {
            return NameSurname + " accessed to system!";
        }
    }
}
