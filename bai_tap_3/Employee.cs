using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
   public  class Employee:IPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Income { get; set; }
        public double Taxcoe { get; set; }
        public string Company { get; set; }
        public string Jobtitle { get; set; }
        TaxData taxdata = new TaxData();
     
        public Employee(int Id, string Name, double Age ,string Company, string Jobtitle, double Income)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Company = Company;
            this.Jobtitle = Jobtitle;
            this.Income = Income;
            this.Taxcoe = taxdata.GetTaxCoe(this);
        }
        public void GetInfo()
        {
            Console.WriteLine("id: {0}  name: {1}  age= {2}  company: {3}  jobtitle: {4}  income: {5}   tax: {6}", Id, Name, Age, Company, Jobtitle ,Income, GetTax());
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
            return Income * taxdata.GetTaxCoe(this) / 100;
        }
    }
}
