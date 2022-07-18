using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEXE
{
    public class Truck : VehicleCompany
    {
        public bool fourWheelDrive { get; set; } = false;
        public bool hasTowPackage { get; set; } = false;
    }
}
