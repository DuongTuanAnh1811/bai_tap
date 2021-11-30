using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    public class Teacher:IPerson
    {

        public int _id { get; set; }
        public string _name { get; set; }
        public double _age { get; set; }
        public double _income { get; set; }
        public string _school { get; set; }
        TaxData taxData= new TaxData();
        public Teacher()
        {

        }
        public Teacher(int id, string name, double age,  string school)
        {
            this._id = id;
            this._name = name;
            this._age = age;
            this._school = school;

        }
        public void GetInfo()
        {
            Console.WriteLine("id:{0}  name:{1}  age= {2} income{3}  school{4} ", _id, _name, _age,_income ,_school);
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
            return _income*taxData.GetTaxCoe(this)/100;
        }
    }
}
