using System;
using System.Collections.Generic;
using System.Text;

namespace HeritageExample.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

        public OutsourcedEmployee() { }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge):base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
    }
}
