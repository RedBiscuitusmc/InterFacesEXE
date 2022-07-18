using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEXE
{
    public class Car : VehicleCompany
    {
        public bool hasTrunk { get; set; } = false;
        public bool isAWD { get; set; } = false;
    }
}
