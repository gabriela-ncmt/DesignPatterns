
namespace FactoryMethod.Vehicle
{
    public class Bicycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Recebemos a solicitação.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando trajeto via bike.");
        }
    }
}
