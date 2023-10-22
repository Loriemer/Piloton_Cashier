using System;

namespace Piloton_Cashier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int moneyOwned;
            int moneyPaid;
            int changeAmount;

            Console.Write("Enter the amount owned: ");
            moneyOwned = int.Parse(Console.ReadLine());

            Console.Write("Enter the amount paid: ");
            moneyPaid = int.Parse(Console.ReadLine());

            changeAmount = moneyPaid - moneyOwned;

            if (moneyPaid < moneyOwned)
            {
                Console.WriteLine("Amount paid is less than the amount owned");
            }
            else
            {
                Console.WriteLine("Amount Change: " + changeAmount.ToString("F2"));
            }
        }
    }
}