using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_1
{
    public class Application
    {
        public static void Init()
        {
            Person.CheckObject().PersonList.Add(new Person(1, "Duong Tuan Anh ", 20, 10000000, 10));
            Person.CheckObject().PersonList.Add(new Person(2, "Nguyen Tuan Anh ", 20, 10000000, 20));
            Person.CheckObject().PersonList.Add(new Person(3, "Tran Duc Anh ", 20, 30000000, 30));
            Person.CheckObject().PersonList.Add(new Person(4, "Nguye Van Tuan", 20, 20000000, 40));
            Person.CheckObject().PersonList.Add(new Person(5, "Lai Thi Thuong ", 20, 10000000, 10));
        }
    }
}
