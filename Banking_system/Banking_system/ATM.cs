using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_system
{
    class ATM
    {
        private double amount;
        private double interest;
        private string owner;
        account TempAccount;
        public double operations()
        {
            Console.WriteLine("Выберите интересующую опреацию:" +
                "1 - открыть вклад, 2 - закрыть вклад, 3 - взять кредит, 4 - открыть дебетовый счёт" +
                "5 - снять деньги, 6 - положить деньги, 7 - закрыть счёт" +
                "8 - перевести деньги");
            int.TryParse(Console.ReadLine(), out int operation);
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    Console.WriteLine("Введите процент");
                    double.TryParse(Console.ReadLine(), out interest);
                    deposit NewDeposit = new deposit();
                    NewDeposit.open(amount, interest);
                    return 0;
                    break;
                case 2:
                    Console.WriteLine("Выберите вклад");
                    deposit closeddep = new deposit();
                    Console.WriteLine("Заберите деньги");
                    return closeddep.close();
                    break;
                case 3:
                    Console.WriteLine("Введите имя владельца");
                    owner = Console.ReadLine();
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    Console.WriteLine("Введите процент");
                    double.TryParse(Console.ReadLine(), out interest);
                    TempAccount = new account();
                    TempAccount.TakeLoan(owner, amount, interest);
                    return 0;
                    break;
                case 4:
                    Console.WriteLine("Введите имя владельца");
                    owner = Console.ReadLine();
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    TempAccount = new account();
                    TempAccount.OpenDebit(owner, amount);
                    return 0;
                    break;
                case 5:
                    Console.WriteLine("Выберите счёт");
                    TempAccount = new account();
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    return TempAccount.TakeMoney(amount);
                    break;
                case 6:
                    Console.WriteLine("Выберите счёт");
                    TempAccount = new account();
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    return TempAccount.PutMoney(amount);
                    break;
                case 7:
                    Console.WriteLine("Выберите счёт");
                    TempAccount = new account();
                    return TempAccount.close();
                    break;
                case 8:
                    Console.WriteLine("Введите адресанта");
                    TempAccount = new account();
                    Console.WriteLine("Введите адресата");
                    account TempAccount1 = new account();
                    string destination = Console.ReadLine();
                    Console.WriteLine("Введите сумму");
                    double.TryParse(Console.ReadLine(), out amount);
                    transaction NewTransaction = new transaction();
                    NewTransaction.SendMoney(amount, TempAccount, TempAccount1);
                    return 0;
                    break;
                default:
                    Console.WriteLine("Введите цифру между 1 и 8");
                    return 0;
                    break;
            }
        }
    }
}
