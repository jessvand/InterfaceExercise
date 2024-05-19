using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool HasFourDoors { get; set; }
        public int NumberOfWheels { get; set; }
        public int Year { get; set ; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CompanyName { get; set; }
        public string WebSite { get; set; }
    } 
}
