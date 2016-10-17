namespace semester7.Program7
{
    public interface IPayable
    {

        int RetrieveAmountDue();
        void AddToAmountDue(int amount);
        void PaymentAddress(string address);
    }
}