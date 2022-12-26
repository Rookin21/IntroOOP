public class BankAccount
{
    /// <summary>
    /// Приватнные полы
    /// </summary>
    private int _Num; // Номер счета    
    private decimal _Balance; // Баланс
    private Card _TypeCard; // Тип банковского счета

    public enum Card // Перечислимое - тип банковского счета
    {
        BankCard,
        CreditCard,
        DebitCard
    };

    /// <summary>
    /// Чтение и запись приватных полей
    /// </summary>
    public int Num { get => _Num; set => _Num = value; }
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="num">Номер счета</param>
    /// <param name="balance">Баланс</param>
    /// <param name="typeCard">Тип банковского счета</param>
    public BankAccount(int num, decimal balance, Card typeCard)
    {
        _Num = num;
        _Balance = balance;
        _TypeCard = typeCard;
    }
}