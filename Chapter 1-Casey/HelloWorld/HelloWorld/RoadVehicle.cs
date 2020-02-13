using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{

    class RoadVehicle
    {
        public static string ProjectVersion = "1.0"; // static member variable
        private int engineSerialNumber { get; }               // instance member variable
        private int numberOfWheels { get; }
        private int carriageCapacity { get; }
        public string Description => string.Format("Road Vehicle. Wheels: {0:d}, Capacity: {1:d} people", NumberOfWheels, CarriageCapacity);
       
        
        
        public RoadVehicle(int EngineSerialNumber, int NumberOfWheels = 4, int CarriageCapacity = 5)
        {
            this.EngineSerialNumber = EngineSerialNumber;
            this.NumberOfWheels = NumberOfWheels;
            this.CarriageCapacity = CarriageCapacity


        }





}
