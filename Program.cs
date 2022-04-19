using System;

namespace ClassBank
{
    public enum BankName { VTB24, Сбербанк, Авангард };

    class BankAccount
    {
        public int Number;
        public double Remain;
        public BankName Name;
        public string OwnerName;
        public string Valuta;

        public void ChangeRemain(double newRemain)
        {
            Remain = newRemain;
        }

        /// <summary>
        /// 'u' для увеличения суммы, 'd' для уменьшения
        /// </summary>
        public void ChangeRemain(int percent, char direction)
        {
            double diff = Remain * 10 / 100;
            if (direction == '+')
                Remain += diff;
            else if (direction == '-')
                Remain -= diff;
        }
    }
    class Program
    {
        static void Main()
        {
            BankAccount account = new BankAccount();
            account.Number = 183;
            account.Remain = 2000;
            account.Name = BankName.Сбербанк;
            account.Valuta = "₽";
            account.OwnerName = "Yan";

            Console.WriteLine(account.Remain);
            account.ChangeRemain(1000);
            Console.WriteLine(account.Remain);
            account.ChangeRemain(30, '+');
            Console.WriteLine(account.Remain);
        }
    }
}