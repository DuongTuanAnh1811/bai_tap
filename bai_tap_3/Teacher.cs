using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    public class Teacher:IPerson
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Age { get; set; }
        public double Income { get; set; }
        public double Taxcoe { get; set; }
        public string School { get; set; }
        TaxData taxdata= new TaxData();
     
        public Teacher(int Id, string Name, double Age,  string School, double Income)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.School = School;
            this.Income = Income;
            this.Taxcoe = taxdata.GetTaxCoe(this);

        }
        public void GetInfo()
        {
            Console.WriteLine("id:{0}  name:{1}  age= {2}  school{3}  income{4}  tax{5}", Id, Name, Age,School ,Income,Taxcoe);
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
            return Income*taxdata.GetTaxCoe(this)/100;
        }
    }
}
