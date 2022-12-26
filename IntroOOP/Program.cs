using static BankAccount;

Console.WriteLine("ДЗ. Урок 2. Две роли класса в ООП");

BankAccount bankAccount = new BankAccount(666, 999.999M, BankAccount.Card.DebitCard); // Заполнение конструктора

Console.WriteLine("\n№ счета: {0} \nБаланс: {1} \nТип банковского счета: {2}", bankAccount.Num, bankAccount.Balance, bankAccount.TypeCard);

Console.ReadKey(true);