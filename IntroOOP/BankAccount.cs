using System.Xml.Linq;

public class BankAccount
{
    private double _Num;
    private decimal _Balance;
    private Card _TypeCard;

    public enum Card
    {
        BankCard,
        CreditCard,
        DebitCard
    };

    public double Num { get => _Num; set => _Num = value; }
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    public BankAccount(double num, decimal balance, Card typeCard)
    {
        _Num = num;
        _Balance = balance;
        _TypeCard = typeCard;
    }
}