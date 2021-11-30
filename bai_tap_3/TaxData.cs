using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    public class TaxData

    { 
      
        public double _taxcoe { get; set; }
    public double GetTaxCoe(IPerson person)
    {
        if (person._age < 18)
        {
            return _taxcoe = 0;
        }
        else if (person._age > 18)
        {
            if (person._income <= 9000000)
            {
                return _taxcoe = 5;
            }
            else if (9000000 < person._income && person._income <= 15000000)
            {
                return _taxcoe = 10;
            }
            else if (15000000 < person._income && person._income <= 20000000)
            {
                return _taxcoe = 15;
            }
            else
            {
                return _taxcoe = 20;
            }
        }
        return 0;
    }
}
}
