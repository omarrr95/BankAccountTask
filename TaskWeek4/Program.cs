using System.Text.Json.Serialization;

namespace TaskWeek4
{
    internal class Program
    {

        static void Main()
        {

            Account mohamedAccount = new Account() { Id = 1, Name = "Mohamed", Balance = 1000.0 };
            Account omarAccount = new Account() { Id = 1, Name = "Mohamed", Balance = 1000.0 };

            omarAccount.Deposite(500);

            mohamedAccount.Withdrow(300);
        }
    }
}