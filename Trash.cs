﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11
{
    class Trash
    {
        public Trash(object value)
        {
            Value = value;
        }
        public Bobr Owner { get; set; }
        public object Value { get; private set; }
    }
}
