﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string SecondName{ get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {SecondName} {LastName}";
        public IEnumerable<PayItem> PayItems { get; set; }
    }
}
