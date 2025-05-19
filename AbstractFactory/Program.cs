using AbstractFactory.App;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;
            ITransportFactory factory;
            string company = "Uber";

            if(company == "Uber")
            {
                factory = new UberTransport();
            }
            else
            {
                factory = new NineNineTransport();
            }

            app = new Application(factory);

            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();
            Console.ReadLine();
        }
    }
}