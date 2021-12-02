using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    public class Application
    {
  
        public static void Init()
        {
            TaxData.CheckObject().person.Add(new Student(1, "Duong Tuan Anh", 21, 12, "tran phu"));
            TaxData.CheckObject().person.Add(new Teacher(1, "Nguyen Duc Ninh", 30, "tran phu", 20000000));
            TaxData.CheckObject().person.Add(new Student(2, "Nguen Xuan Dien", 21, 12, "tran quoc toan"));
            TaxData.CheckObject().person.Add(new Employee(1, "Lai Thi Thuong", 30, "kinh do", "quan ly", 10000000));
            TaxData.CheckObject().person.Add(new Employee(2, "Nguyen Tien Anh", 30, "kinh do", "pho giam doc", 30000000));
        }

    }
}
