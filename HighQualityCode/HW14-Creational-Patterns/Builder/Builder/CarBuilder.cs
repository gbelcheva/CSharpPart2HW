namespace CarExample.Builder
{
    using CarExample.Builder.Contracts;

    public class CarBuilder : ICarBuilder
    {
        private ICar car = new MyCar();

        public void AddAirFilter()
        {
            this.car.Add("Air Filter");
        }

        public void AddAlternator()
        {
            this.car.Add("Alternator");
        }

        public void AddBattery()
        {
            this.car.Add("Battery");
        }

        public void AddCarburetor()
        {
            this.car.Add("Carburetor");
        }

        public void AddCoolingTank()
        {
            this.car.Add("Cooling tank");
        }

        public void AddDistributor()
        {
            this.car.Add("Distributor");
        }

        public void AddExhaust()
        {
            this.car.Add("Exhaust");
        }

        public void AddFuelInjectionSystem()
        {
            this.car.Add("Fuel Injection System");
        }

        public void AddMuffler()
        {
            this.car.Add("Muffler");
        }

        public void AddSuspension()
        {
            this.car.Add("Suspension");
        }

        public void AddPowerSteeringReservoir()
        {
            this.car.Add("Power Steering Reservoir");
        }

        public void AddBrakeFluidReservoir()
        {
            this.car.Add("Brake Fluid Reservoir");
        }

        public void AddDiscBrakes()
        {
            this.car.Add("Disc Brakes");
        }

        public void AddRearAxle()
        {
            this.car.Add("Rear Axle");
        }

        public void AddRadiator()
        {
            this.car.Add("Radiator");
        }

        public ICar GetResult()
        {
            return this.car;
        }
    }

}
