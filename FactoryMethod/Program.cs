using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        public static void Main(String[] args)
        {
            Transport transport = null;
            if(args.Length > 0)
            {
                switch (args[0])
                {
                    case "--uber":
                        transport = new CarTransport();
                        break;
                    case "--log":
                        transport = new MotorCycleTransport();
                        break;
                    case "--food":
                        transport = new BicycleTransport();
                        break;
                    default:
                        Console.WriteLine("Selecione o tipo de Serviço");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Selecione o tipo de Serviço");
            }

            if(transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}