namespace BankAccount
{
    internal class Program
    {
        static void Main()
        {
            var choiceType = true;

            List<Account> myAccount = new List<Account>
{
    new Account { Id = 1, Name = "Omar", Balance = 8000.0 },
    new Account { Id = 2, Name = "Mohamed", Balance = 2000.0 },
    new Account { Id = 3, Name = "Ahmed", Balance = 3000.0 },
    new Account { Id = 4, Name = "Mahmoud", Balance = 500.0 },
    new Account { Id = 5, Name = "Hassan", Balance = 5000.0 }
};

            do
            {
                Console.Write("Enter Account id : ");
                int desiredId = int.Parse(Console.ReadLine());
                // using LINQ FirstOrDefault to find ID Dynamic
                Account foundAccount = myAccount.FirstOrDefault(obj => obj.Id == desiredId);

                if (foundAccount != null)
                {
                    Console.WriteLine($"Hello Mr. {foundAccount.Name} Please choose what you want to do ");
                    Console.WriteLine("To Out press 0");
                    Console.WriteLine("for Deposite press 1");
                    Console.WriteLine("for withdrow press 2");
                    Console.WriteLine("for Show All Information press 3");
                    var choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Write("Enter mount You want to deposite : ");
                                var depositeValue = int.Parse(Console.ReadLine());
                                foundAccount.Balance += depositeValue;
                                Console.WriteLine($"Thanks Mr {foundAccount.Name} your Balance is {foundAccount.Balance}");
                                Console.Write("Wan't To make more transaction to Yes press 1 or No press 0 ? : ");
                               int otherTransaction = int.Parse(Console.ReadLine());
                                Repeat(otherTransaction, choiceType);
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Enter mount You want to withdrow : ");
                                var withdrowValue = int.Parse(Console.ReadLine());
                                if (withdrowValue < foundAccount.Balance)
                                {
                                    foundAccount.Balance -= withdrowValue;
                                    Console.WriteLine($"Thanks Mr {foundAccount.Name} your Balance is {foundAccount.Balance}");
                                }
                                else
                                {
                                    Console.WriteLine($"Heloow Mr.{foundAccount.Name} ,you can't withdrow {withdrowValue} becouse this biggerthan your Balance {foundAccount.Balance}");
                                }
                                Console.Write("Wan't To make more transaction to Yes press 1 or No press 0 ? : ");
                                int otherTransaction = int.Parse(Console.ReadLine());
                                Repeat(otherTransaction, choiceType);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine($"Your Name is : {foundAccount.Name}");
                                Console.WriteLine($"Your id is : {foundAccount.Id}");
                                Console.WriteLine($"Your Balance is : {foundAccount.Balance}");
                                Console.Write("Wan't To make more transaction to Yes press 1 or No press 0 ? : ");
                                int otherTransaction = int.Parse(Console.ReadLine());
                                Repeat(otherTransaction, choiceType);
                                break;
                            }
                        case 0:
                            {
                                Console.Write("Thanks For choice Us");
                                Console.Write("Wan't To make more transaction to Yes press 1 or No press 0 ? : ");
                                int otherTransaction = int.Parse(Console.ReadLine());
                                Repeat(otherTransaction, choiceType);
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Unknown choice");
                                Console.Write("Wan't To make more transaction to Yes press 1 or No press 0 ? : ");
                                int otherTransaction = int.Parse(Console.ReadLine());
                                Repeat(otherTransaction, choiceType);
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Your Account not found.");
                }
            }
            while (choiceType);
        }
        public static void Repeat(int otherTransaction, bool choiceType)
        {
           
            switch (otherTransaction)
            {
                case 1:
                    {
                        choiceType = true;
                        break;
                    }
                case 0:
                    {
                        choiceType = false;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Unknown choice");
                        choiceType = false;
                        break;
                    }
            }
            return;
        }
    }
}