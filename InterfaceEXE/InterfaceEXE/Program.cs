namespace InterfaceEXE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            //!Create 2 Interfaces called IVehicle & ICompany--Done
            //!Create 3 classes called Car , Truck , & SUV--Done
            //TODO your IVehicle
            //!Create 4 members that Car, Truck, & SUV all have in common.--Done
            //TODO ICompany
            //!Create 2 members that are specific to each every company--Done
            //TODOIn each of your car, truck, and suv classes
            //!Create 2 members that are specific to each class--Done
            //! Example: truck has a bed size while car has a trunk while suv has a cargo hold size--Done
            //!Then, Set each class to inherit from both IVehicle and ICompany and implement their members.--Done
            //TODONow, create objects of your 3 classes and give their members values;
            //!Creatively display and organize their values--Done

            var vehicles = new List<VehicleCompany>();

            Truck truck = new Truck();
            truck.Make = "Ford";
            truck.Model = "Ranger";
            truck.Year = "1998";
            truck.Logo = "Ford Motor Company";
            truck.MissionStatement = "Helping people go places";
            truck.fourWheelDrive = true;
            truck.hasTowPackage = true;

            Car car = new Car();
            car.Make = "Honda";
            car.Model = "Civic";
            car.Year = "2004";
            car.Logo = "Honda Motors";
            car.MissionStatement = "Honda takes you places";
            car.isAWD = true;
            car.hasTrunk = true;

            SUV sUV = new SUV();
            sUV.Make = "Jeep";
            sUV.Model = "Wrangler";
            sUV.Year = "2008";
            sUV.Logo = "Jeep Wranglers Wranglers";
            sUV.MissionStatement = "Go places never seen before.";
            sUV.CargoSize = "Not very much.";
            sUV.hasThirdSeat = false;
            
            vehicles.Add(truck);
            vehicles.Add(car);
            vehicles.Add(sUV);
      
            foreach (VehicleCompany vehicle in vehicles)
            {
                Console.WriteLine($"\nMake: {vehicle.Make}\n Model: {vehicle.Model} \n Year: {vehicle.Year}");
                Console.WriteLine($"\nCaroSize: {sUV.CargoSize}\n ThirdSeat: {sUV.hasThirdSeat} \n MissionStatement: {sUV.MissionStatement}");
            }



        }
    }
}