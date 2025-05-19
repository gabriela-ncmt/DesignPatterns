namespace AbstractFactory.LandVehicles
{
    public class MotorCycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a encomenda");
        }
    }
}
