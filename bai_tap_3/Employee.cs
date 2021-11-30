using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
   public  class Employee:IPerson
    {

        public int _id { get; set; }
        public string _name { get; set; }
        public double _age { get; set; }
        public double _income { get; set; }
        public string _company { get; set; }
        public string _jobtitle { get; set; }
        TaxData taxdata = new TaxData();
        public Employee()
        {

        }
        public Employee(int id, string name, double age, double income ,string company, string jobtitle)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._income = income;
           this._company = company;
            this._jobtitle = jobtitle;
        }
        public void GetInfo()
        {
            Console.WriteLine("id:{0}  name:{1}  age= {2}  company{3}  jobtitle{4} income{5}", _id, _name, _age, _company, _jobtitle,_income);
        }
        public bool Equals(IPerson p)
        {
            if (this == p)
            {
                return true;
            }
            return false;
        }
        public double GetTax()
        {
            return _income * taxdata.GetTaxCoe(this) / 100;
        }
    }
}
