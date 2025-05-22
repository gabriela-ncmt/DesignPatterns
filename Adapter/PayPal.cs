namespace Adapter
{
    public class PayPal : IPayPalPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void PayPalReceive()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PayPayPayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
