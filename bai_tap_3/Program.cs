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
         static List<TaxData> taxdatalist = new List<TaxData>();
         static List<Student> stlist = new List<Student>();
        static List<Employee> emplist = new List<Employee>();
        static List<Teacher>tclist= new List<Teacher>();

        static int countstudent=0;
        public static void Init()
        {
            stlist.Add(new Student(1, "Duong Tuan Anh ", 20,12,"tran phu"));
            stlist.Add(new Student(2, "Duong Quynh Anh ", 10, 12, "tran phu"));

            emplist.Add(new Employee(1,"Lai Thi Thuong",20,20000000,"Hai Hoa","quan ly"));
           
        }
            public static void OutPut()
            {
              foreach (Student student in stlist)
            {
                ++countstudent;
                Console.WriteLine(" id:{0}  name:{1}  age= {2}  class: {3}  school: {4}  ", student._id, student._name, student._age, student._class, student._school);
                        
            }
            Console.WriteLine("student so luong ="+countstudent);
              foreach(Employee emp in emplist)
            {
                Console.WriteLine("id:{0}  name:{1}  age= {2}  company: {3}  jobtitle: {4} tax: {5}", emp._id, emp._name, emp._age, emp._company, emp._jobtitle, emp.GetTax());
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
