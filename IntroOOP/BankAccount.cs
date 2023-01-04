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
    public int Num { get => _Num;}
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="num">Номер счета</param>
    /// <param name="balance">Баланс</param>
    /// <param name="typeCard">Тип банковского счета</param>
    public BankAccount(decimal balance, Card typeCard)
    {
        Random RND = new Random();
        _Num = RND.Next(100);
        _Balance = balance;
        _TypeCard = typeCard;
    }
    public decimal Deposit(decimal amount)
    {
        _Balance += amount;
         return _Balance;
    }

    public decimal Withdraw(decimal amount)
    {
        if (amount > _Balance)
        {
            Console.WriteLine("Запрашиваемая сумма превышает остаток на счете {0}", _Num);
        }
        else
        {
            _Balance-= amount;
        }

        return _Balance;
    }

    public void Exchange(decimal amount, BankAccount firstAccount, BankAccount secondAccount)
    {
        firstAccount.Withdraw(amount);
        secondAccount.Deposit(amount);
    }
}