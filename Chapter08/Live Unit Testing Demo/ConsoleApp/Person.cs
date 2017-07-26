using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class Person : ICloneable
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}



