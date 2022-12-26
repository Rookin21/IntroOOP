using System.Xml.Linq;

public class BankAccount
{
    /// <summary>
    /// ���������� ����
    /// </summary>
    private double _Num; // ����� �����    
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
    public double Num { get => _Num; set => _Num = value; }
    public decimal Balance { get => _Balance; set => _Balance = value; }
    public Card TypeCard { get => _TypeCard; set => _TypeCard = value; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="num">����� �����</param>
    /// <param name="balance">������</param>
    /// <param name="typeCard">��� ����������� �����</param>
    public BankAccount(double num, decimal balance, Card typeCard)
    {
        _Num = num;
        _Balance = balance;
        _TypeCard = typeCard;
    }
}