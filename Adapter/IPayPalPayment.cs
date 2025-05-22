namespace Adapter
{
    public interface IPayPalPayment
    {
        Token AuthToken();
        void PayPayPayment();
        void PayPalReceive();
    }
}
