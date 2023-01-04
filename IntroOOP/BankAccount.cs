public class BankAccount
{
    /// <summary>
    /// ���������� ����
    /// </summary>
    private int _Num; // ����� �����    
    private decimal _Balance; // ������
    private Card _TypeCard; // ��� ����������� �����

    public enum Card // ������������ - ��� ����������� �����
    {
        BankCard,
        CreditCard,
        DebitCard
    };

    /// <summary>
    /// ������ � ������ ��������� �����
    /// </summary>
    public int Num { get => _Num;}
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="num">����� �����</param>
    /// <param name="balance">������</param>
    /// <param name="typeCard">��� ����������� �����</param>
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
            Console.WriteLine("������������� ����� ��������� ������� �� ����� {0}", _Num);
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