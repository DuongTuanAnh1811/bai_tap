using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace bai_tap_2
{
    class Program
    {
        public static void OutPut()
        {
            Console.WriteLine("Person {0}", Person.CheckObject().PersonList.Count<Person>());
            foreach (Person person in Person.CheckObject().PersonList)
            {
                person.GetInfo();
            }
        }

        static void Main(string[] args)
        { 
           Application.Init();
            OutPut();
            Console.ReadKey();
        }
    }
}
