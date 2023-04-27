namespace eLoopV2.Models

{

    public class ElectricCar
    {
        public int ID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public int BatteryCapacity { get; set; }
        public int ChargingTime { get; set; }
        public string PlateNumber { get; set; }
        public bool IsAvailable { get; set; }
        public Location Location { get; set; }
    }

}


