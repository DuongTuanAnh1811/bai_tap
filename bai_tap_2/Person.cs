using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace bai_tap_2
{
    class Person
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public double _age { get; set; }
        public double _income { get; set; }
      TaxData taxdata= new TaxData();
        public Person()
        {

        }
        public Person(int id, string name, double age, double income)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._income = income;
          
        }
        public bool Equals(Person p)
        {
            if (this == p)
            {
                return true;
            }
            return false;
        }
        public double GetTax()
        {
            return _income *taxdata.GetTaxCoe(this) / 100;
        }

        
    }
}

