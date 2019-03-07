using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorce1.Prototype
{
    class EmployeePrototype
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DailyHours { get; set; }
        public int Holidays { get; set; }

        public EmployeePrototype Clone()
        {
            return new EmployeePrototype
            {
                Name = Name,
                LastName = LastName,
                DailyHours = DailyHours,
                Holidays = Holidays
            };
        }

        public override string ToString()
        {
            return $"Nazwa: {Name}, Lastname: {LastName}, DailyHours: {DailyHours}, Holidays - {Holidays}";
        }
    }

}
