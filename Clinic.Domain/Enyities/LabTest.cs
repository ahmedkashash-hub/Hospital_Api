using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class LabTest:BaseAuditableEntity
    {
       private LabTest() { }
        public LabTest( string name,string normalValue,decimal price)
        {
            Name = name;
            NormalValue = normalValue;
            Price = price;
        }
        public string? Name { get;private set; }
        public string? NormalValue { get; private set; }

        public decimal Price { get; private set; }


        public LabTest Add(string name, string normalValue, decimal price) =>new LabTest(name, normalValue, price);


        public void Update(string name, string normalValue, decimal price)
        {
            Name=name;
            NormalValue=normalValue;
            Price = price;
        }
    }
}
