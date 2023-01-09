using static BankAccount;

//Console.WriteLine("ДЗ. Урок 2. Две роли класса в ООП");

//BankAccount bankAccount1 = new BankAccount(777.777M, BankAccount.Card.DebitCard); // Заполнение конструктора
//BankAccount bankAccount2 = new BankAccount(666.666M, BankAccount.Card.CreditCard);
//BankAccount bankAccount3 = new BankAccount(111.111M, BankAccount.Card.BankCard);

//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount1.Num, bankAccount1.Balance, bankAccount1.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount2.Num, bankAccount2.Balance, bankAccount2.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount3.Num, bankAccount3.Balance, bankAccount3.TypeCard);

//Console.WriteLine("\nВыполнено пополнение счета:");
//bankAccount1.Deposit(111.111M);
//bankAccount2.Deposit(111.111M);
//bankAccount3.Deposit(111.111M);

//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount1.Num, bankAccount1.Balance, bankAccount1.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount2.Num, bankAccount2.Balance, bankAccount2.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount3.Num, bankAccount3.Balance, bankAccount3.TypeCard);

//Console.WriteLine("\nВыполнено снятие со счета:");
//bankAccount1.Withdraw(111.111M);
//bankAccount2.Withdraw(111.111M);
//bankAccount3.Withdraw(322.222M);

//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount1.Num, bankAccount1.Balance, bankAccount1.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount2.Num, bankAccount2.Balance, bankAccount2.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount3.Num, bankAccount3.Balance, bankAccount3.TypeCard);

//Console.WriteLine("\nВыполнен перевод со счета №{0} на счет №{1}", bankAccount1.Num, bankAccount2.Num);
//bankAccount1.Exchange(100.000M, bankAccount1, bankAccount2);

//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount1.Num, bankAccount1.Balance, bankAccount1.TypeCard);
//Console.WriteLine("\n№ счета: {0} \nБаланс: {1} $ \nТип банковского счета: {2}", bankAccount2.Num, bankAccount2.Balance, bankAccount2.TypeCard);

Console.WriteLine("ДЗ. Урок 3. Особенности работы с объектами");
Console.Write("Введите текст для инверсии: ");

string StringLine = Console.ReadLine();

FileWork fileWork = new FileWork();

Console.WriteLine(fileWork.ReverseString(StringLine));

Console.ReadKey(true);