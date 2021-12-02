using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
   public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        double Age { get; set; }
        double Income { get; set; }
        double Taxcoe { get; set; }

        void GetInfo();
        bool Equals(IPerson p);
        double GetTax();
    }
}

