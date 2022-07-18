using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEXE
{
    public class SUV : VehicleCompany
    {
        public string CargoSize { get; set; } = "Default";
        public bool hasThirdSeat { get; set; } = false;
    }
}
