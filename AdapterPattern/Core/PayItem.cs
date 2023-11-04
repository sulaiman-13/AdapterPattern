﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class PayItem
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsDeduction { get; set; }

    }
}
