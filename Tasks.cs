using System;

namespace Sharp11
{
    public enum TypeOfAccount {Debit, Credit}

    public class Account
    {
        private int _number;

        private static int _counter = 1;

        private decimal _balance;

        private TypeOfAccount _typeAccount;

        public Account()
        {
            _number = Increase();
        }

        private static int Increase()
        {
            return _counter++;
        }

        public void FillNumber(int number)
        {
            _number = number;
        }

        public void FillBalance(decimal balance)
        {
            _balance = balance;
        }

        public void FillTypeAccount(TypeOfAccount typeAccount)
        {
            _typeAccount = typeAccount;
        }

        public void FullInfo()
        {
            Console.WriteLine($"Type Of Account: {_typeAccount}, Number of Account: {_number}, Balance: {_balance}");
        }
    }
}