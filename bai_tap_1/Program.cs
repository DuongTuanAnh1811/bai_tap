using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace bai_tap_1
{
    class Program
    {
        static List<Person> Person;

        public static void Init()
        {
            Person = new List<Person>();
            Person.Add (new Person(1, "Duong Tuan Anh ", 20, 10000000, 10));
            Person.Add(new Person(2, "Nguyen Tuan Anh ", 20, 10000000, 20));
            Person.Add(new Person(3, "Tran Duc Anh ", 20, 30000000, 30));
            Person.Add(new Person(4, "Nguye Van Tuan", 20, 20000000, 40));
            Person.Add(new Person(5, "Lai Thi Thuong ", 20, 10000000, 10));
        }
        public static void OutPut()
            {
        
            foreach (Person person in Person)
            {
                Console.WriteLine("id:{0}  name:{1}  tax= {2} ", person.Id, person.Name, person.GetTax());
            }
            }
        
        static void Main(string[] args)
        {
            Init();
            OutPut();
            Console.ReadKey();
        }
    }
}
