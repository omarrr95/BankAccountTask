using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Hello {Name} Deposite sucsess your balance is {Balance}");
            }
            else
            {
                Console.WriteLine("Hello {Name} Deposite fail.");
            }
        }
        public void Withdrow(double amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
                Console.WriteLine($"Hello {Name} Withdrow sucsess your balance is {Balance}");
            }
            else
            {
                Console.WriteLine("Hello {Name} Withdrow fail.");
            }
        }
    }
}
