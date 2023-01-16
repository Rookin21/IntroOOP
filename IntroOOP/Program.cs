using System.IO;

namespace IntroOOP
{
    public static class Program
    {
        private const string __NameFileName = "FIO.txt";
        private const string __CreateStudents = "Result.txt";
        private const int __StudentsCount = 10;

        public static void Main(string[] args)
        {

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

            //string[] last_names;
            //string[] first_names;
            //string[] patronymics;
            //string[] symbols;
            //string[] mails;

            //GetFIOs(__NameFileName, out last_names, out first_names, out patronymics, out symbols, out mails);

            // Выше тоже самое, это упрощенная
            GetFIOs(__NameFileName, out var last_names, out var first_names, out var patronymics, out var symbols, out var mails);
            CreateStudents(__CreateStudents, __StudentsCount, mails);

            Console.ReadKey(true);

        }

        // Задание 3
        public static void GetFIOs(
            string SourceFilePath, 
            out string[] LastNames, 
            out string[] FirstNames, 
            out string[] Patronmics,
            out string[] Symbols,
            out string[] Mails)
        {
            if (!File.Exists(SourceFilePath))
                throw new FileNotFoundException("Файл c данными ФИО не найдет", SourceFilePath);

            var last_names = new List<string>();
            var first_names = new List<string>();
            var patronymics = new List<string>();
            var symbols = new List<string>();
            var mails = new List<string>();

            using(var file = File.OpenText(SourceFilePath))
            {
                while(file.EndOfStream)
                {
                    var line = file.ReadLine();
                    if (line!.Length == 0) continue;

                    var elements = line.Split(' ');
                    if (elements.Length < 5) continue;

                    last_names.Add(elements[0]);
                    first_names.Add(elements[1]);
                    patronymics.Add(elements[2]);
                    symbols.Add(elements[3]);
                    mails.Add(elements[4]);
                }
            }

            LastNames = last_names.ToArray();
            FirstNames = first_names.ToArray();
            Patronmics = patronymics.ToArray();
            Symbols = symbols.ToArray();
            Mails = mails.ToArray();

        }

        private static void CreateStudents(
            string StudentsFilePath, 
            int Count,       
            string[] Mails)
        {
            using (var file= File.CreateText(StudentsFilePath))
            for (var i = 0; i < Count; i++)
            {
                file.WriteLine(string.Join("\n", Mails));
            }
            
        }
    }
}