using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_2
{
    public class Application
    {
        public static void Init()
        {
            Person.CheckObject().PersonList.Add(new Person(1, "Duong Tuan Anh ", 10, 10000000));
            Person.CheckObject().PersonList.Add(new Person(2, "Nguyen Tuan Anh ", 11, 10000000));
            Person.CheckObject().PersonList.Add(new Person(3, "Tran Duc Anh ", 20, 30000000));
            Person.CheckObject().PersonList.Add(new Person(4, "Nguye Van Tuan", 20, 20000000));
            Person.CheckObject().PersonList.Add(new Person(5, "Lai Thi Thuong ", 20, 10000000));
        }
    }
}
