namespace AbstractFactory.AirCrafts
{
    public class Airplane : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando os ventos...");
            Console.WriteLine("...ventos a 25km...");
            Console.WriteLine("...ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros à bordo, voô autorizado!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem...");
        }
    }
}
