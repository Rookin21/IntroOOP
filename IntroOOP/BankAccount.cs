public class BankAccount
{
    private double _Num;
    private decimal _Balance;

    public enum _TypeCard
    {
        _BankCard,
        _CreditCard,
        _DebitCard
    };

    public BankAccount() { }

    public double Num { get; set; }
    public decimal Balance { get; set; }
}