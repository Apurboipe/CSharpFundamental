using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAndClass.Person
{
    class PersonInfo
    {
        public string firstName;
        public string lastname;

        public void showName()
        {
            Console.WriteLine("Person name is " + firstName + " " + lastname);
        }
    }
}
