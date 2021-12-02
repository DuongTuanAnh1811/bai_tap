using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai_tap_1
{
     class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Income { get; set; }
        public double Taxcoe { get; set; }

        public Person()
        {

        }
        public Person(int Id, string Name, double Age, double Income, double Taxcoe)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Income = Income;
            this.Taxcoe = Taxcoe;
        }

        public bool Equals(Person p)
        {
            if (this== p)
            {
                return true;
            }
            return false;
        }
        public double GetTax()
        {
            return Income * Taxcoe / 100;
        }

    }
}
