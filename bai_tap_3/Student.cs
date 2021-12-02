using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
   public class Student : IPerson
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Income { get; set; }
       public double Taxcoe { get; set; }
        public int Class { get; set; }
        public string School { get; set; }

           public Student(int Idd,string Name, double Age, int Class, string School)
        {
           this.Id = Idd;
            this.Name = Name;
            this.Age = Age;
           this.Class = Class;
            this.School = School;
        }
        public void GetInfo()
        {
            Console.WriteLine("id: {0}  name: {1}  age= {2}  class: {3}  school: {4} ", Id,Name,Age,Class,School);
        }
    
        public bool Equals(IPerson p)
        {
            if(this == p)
            {
                return true;
            }
            return false;
        }
        public double GetTax()
        {
            return 0;
        }
    }
}
