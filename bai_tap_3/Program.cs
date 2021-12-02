using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace bai_tap_3
{
    class Program
    { 

        public static void OutPut()
            {
            Console.WriteLine("Student {0}", TaxData.CheckObject().person.OfType<Student>().Count<Student>());
            foreach(Student student in TaxData.CheckObject().person.OfType<Student>())
            {
                student.GetInfo();
            }
            Console.WriteLine("Teacher {0}", TaxData.CheckObject().person.OfType<Teacher>().Count<Teacher>());
            foreach (Teacher teacher in TaxData.CheckObject().person.OfType<Teacher>())
            {
                teacher.GetInfo();
            }
            Console.WriteLine("Employee {0}", TaxData.CheckObject().person.OfType<Employee>().Count<Employee>());
            foreach (Employee employee in TaxData.CheckObject().person.OfType<Employee>())
            {
                employee.GetInfo();
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
