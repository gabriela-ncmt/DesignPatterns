using Builder.Builders;
using Builder.Components;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }
        public void ConstructSedan()
        {
            builder.SetVehicleType(VehicleType.SEDAN);
            builder.setEngine(new Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Transmission.AUTOMATIC);
        }

        public void ConstructTruck()
        {
            builder.SetVehicleType(VehicleType.TRUCK);
            builder.setEngine(new Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Transmission.MANUAL);
        }
    }
}
