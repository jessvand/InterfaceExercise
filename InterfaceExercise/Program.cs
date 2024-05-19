using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var shirleyTilda = new Car();

            shirleyTilda.Year = 2020;
            shirleyTilda.Make = "Chevrolet";
            shirleyTilda.Model = "Cobalt";
            shirleyTilda.NumberOfWheels = 4;
            shirleyTilda.HasFourDoors = false;
            shirleyTilda.CompanyName = "Chevy to the Levy";
            shirleyTilda.WebSite = "chevylevybaybee.org";

            var bubbaTruck = new Truck();

            bubbaTruck.Year = 2024;
            bubbaTruck.Make = "Chevrolet";
            bubbaTruck.Model = "Silverado";
            bubbaTruck.HasCamperShell = true;
            bubbaTruck.NumberOfDoors = 4;
            bubbaTruck.NumberOfWheels = 5;
            bubbaTruck.CompanyName = "Chevy to the Levy";
            bubbaTruck.WebSite = "chevylevybaybee.org";

            var agnesMarie = new SUV();

            agnesMarie.Year = 2025;
            agnesMarie.Make = "Toyota";
            agnesMarie.Model = "Sequoia";
            agnesMarie.NumberOfWheels = 5;
            agnesMarie.AmountOfSeats= 8;
            agnesMarie.CompanyName = "Buy Toy Yoda, You Will";
            agnesMarie.WebSite = "yoyodatoy.com";

              var carPark = new List<IVehicle>() {shirleyTilda, bubbaTruck, agnesMarie};

            foreach(var vehicle in carPark)
            {
                Console.WriteLine($"Here is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.\nWheels:{vehicle.NumberOfWheels}\n");
            }
            
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
