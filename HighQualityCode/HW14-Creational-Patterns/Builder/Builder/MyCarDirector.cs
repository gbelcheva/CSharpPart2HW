namespace CarExample.Builder
{
    using CarExample.Builder.Contracts;

    public class MyCarDirector
    {
        public void Construct(ICarBuilder builder)
        {
            builder.AddAirFilter();

            builder.AddAlternator();

            builder.AddBattery();

            builder.AddCarburetor();

            builder.AddCoolingTank();

            builder.AddDistributor();

            builder.AddExhaust();

            builder.AddFuelInjectionSystem();

            builder.AddMuffler();

            builder.AddSuspension();

            builder.AddPowerSteeringReservoir();

            builder.AddBrakeFluidReservoir();

            builder.AddDiscBrakes();

            builder.AddRearAxle();

            builder.AddRadiator();
        }
    }
}
