using static BankAccount;

Console.WriteLine("ДЗ. Урок 2. Две роли класса в ООП");

BankAccount bankAccount1 = new BankAccount(999.999M, BankAccount.Card.DebitCard); // Заполнение конструктора
BankAccount bankAccount2 = new BankAccount(666.666M, BankAccount.Card.CreditCard);
BankAccount bankAccount3 = new BankAccount(111.111M, BankAccount.Card.BankCard);

Console.WriteLine("\n№ счета: {0} \nБаланс: {1} \nТип банковского счета: {2}", bankAccount1.Num, bankAccount1.Balance, bankAccount1.TypeCard);
Console.WriteLine("\n№ счета: {0} \nБаланс: {1} \nТип банковского счета: {2}", bankAccount2.Num, bankAccount2.Balance, bankAccount2.TypeCard);
Console.WriteLine("\n№ счета: {0} \nБаланс: {1} \nТип банковского счета: {2}", bankAccount3.Num, bankAccount3.Balance, bankAccount3.TypeCard);

Console.ReadKey(true);