﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace bai_tap_2
{
    class Program
    {
        static List<Person> Personlist = new List<Person>();


        public static void Init()
        {
            Personlist.Add(new Person(1, "Duong Tuan Anh ", 10, 10000000));
            Personlist.Add(new Person(2, "Nguyen Tuan Anh ", 11, 10000000));
            Personlist.Add(new Person(3, "Tran Duc Anh ", 20, 30000000));
            Personlist.Add(new Person(4, "Nguye Van Tuan", 20, 20000000));
            Personlist.Add(new Person(5, "Lai Thi Thuong ", 20, 10000000));
        }
        public static void OutPut()
        {
            foreach (Person person in Personlist)
            {
                
                Console.WriteLine("id:{0}  name:{1}  tax= {2}   ", person._id, person._name, person.GetTax());
            }
        }

        static void Main(string[] args)
        { 
            Init();
            OutPut();
            Console.ReadKey();
        }
    }
}