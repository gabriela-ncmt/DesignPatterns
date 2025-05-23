using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Servers;

namespace ChainOfResponsability
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@teste.com", "master@342341w#as");
            server.RegisterUser("user@teste.com", "user234235");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args) 
        { 
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Digite a senha: ");
                string password = Console.ReadLine();

                done = server.Login(email, password);
            } while (!done);
            Console.ReadLine();
        }
    }
}