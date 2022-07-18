using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEXE
{
    public class VehicleCompany : IVehicle, ICompany
    {
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";
        public string Year { get; set; } = "Default";
        public string Type { get; set; } = "Default";
        public string Logo { get; set; } = "Default";
        public string MissionStatement { get; set; } = "Default";
    }
}
