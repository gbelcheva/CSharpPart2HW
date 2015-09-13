namespace CarExample.Builder.Contracts
{
    public interface ICarBuilder
    {
        void AddAirFilter();

        void AddAlternator();

        void AddBattery();

        void AddCarburetor();

        void AddCoolingTank();

        void AddDistributor();

        void AddExhaust();
        
        void AddFuelInjectionSystem();
        
        void AddMuffler();
        
        void AddSuspension();
        
        void AddPowerSteeringReservoir();
        
        void AddBrakeFluidReservoir();
        
        void AddDiscBrakes();
        
        void AddRearAxle();
        
        void AddRadiator();

        ICar GetResult();
    }
}
