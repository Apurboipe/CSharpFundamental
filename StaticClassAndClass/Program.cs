using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticClassAndClass.Person;

namespace StaticClassAndClass
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonInfo aPersonInfo = new PersonInfo();
            aPersonInfo.firstName = "apurbo";
            aPersonInfo.lastname = "saha";
            aPersonInfo.showName();
            calculator.add(2, 3);
            Console.ReadKey();
        }
    }
}
