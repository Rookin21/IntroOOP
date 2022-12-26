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
    public int Num { get => _Num; set => _Num = value; }
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="num">����� �����</param>
    /// <param name="balance">������</param>
    /// <param name="typeCard">��� ����������� �����</param>
    public BankAccount(int num, decimal balance, Card typeCard)
    {
        _Num = num;
        _Balance = balance;
        _TypeCard = typeCard;
    }
}