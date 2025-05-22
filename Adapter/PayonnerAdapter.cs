namespace Adapter
{
    public class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando adaptação de Payonner para os métodos do PayPal");
        }
        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalReceive()
        {
            this.payonner.SendPayment();
        }

        public void PayPayPayment()
        {
            this.payonner.ReceivePayment();
        }
    }
}
