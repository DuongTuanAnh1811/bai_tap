using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    public class TaxData

    {
        public  List<IPerson> person { get; set; }

        public static TaxData Check ;
        public TaxData()
        {
            this.person = new List<IPerson>();
        }
        public static TaxData CheckObject() 
        {
            if (TaxData.Check == null)
            {
                return TaxData.Check = new TaxData();
            }
            return TaxData.Check;
        }

        public double GetTaxCoe(IPerson person)
    {
        if (person.Age < 18)
        {
            return person.Taxcoe = 0;
        }
        else if (person.Age > 18)
        {
            if (person.Income <= 9000000)
            {
                return person.Taxcoe = 5;
            }
            else if (9000000 < person.Income && person.Income <= 15000000)
            {
                return person.Taxcoe = 10;
            }
            else if (15000000 < person.Income && person.Income <= 20000000)
            {
                return person.Taxcoe = 15;
            }
            else
            {
                return person.Taxcoe = 20;
            }
        }
        return 0;
    }
}
}
