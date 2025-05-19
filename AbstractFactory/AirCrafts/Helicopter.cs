namespace AbstractFactory.AirCrafts
{
    public class Helicopter : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento...");
            Console.WriteLine("...vento sudeste...");
            Console.WriteLine("...ventos Ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros OK. Ligando as helices!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!!!");
        }
    }
}
