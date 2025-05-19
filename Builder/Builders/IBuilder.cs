using Builder.Components;
using Builder.Products;

namespace Builder.Builders
{
    public interface IBuilder
    {
        void Reset();
        Vehicle GetVehicle();
        void SetSeats(int seats);
        void setEngine(Engine engine);
        void SetTransmission(Transmission transmission);
        void SetVehicleType(VehicleType vehicleType);
    }
}
