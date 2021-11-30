using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
   public interface IPerson
    {
        int _id { get; set; }
        string _name { get; set; }
        double _age { get; set; }
        double _income { get; set; }
        void GetInfo();
        bool Equals(IPerson p);
        double GetTax();
    }
}

