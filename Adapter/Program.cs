namespace Adapter
{
    class Program
    {
        static void Main(string[] args) {
           IPayPalPayment payment = new PayonnerAdapter(new Payonner());

            payment.PayPayPayment();
            payment.PayPalReceive();


            Console.ReadLine();
        }
    }
}