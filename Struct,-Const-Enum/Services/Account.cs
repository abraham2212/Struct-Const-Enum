﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Const_Enum.Services
{
    internal class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Account( string name , string surname,int age,string address)
        {
            Name=name;
            Surname=surname;
            Age=age;
            Address=address;

        }
        public override string ToString()
        {
            return $"{Name}  {Surname} {Age} {Address}";
        }



    }
}
