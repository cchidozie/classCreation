using System;


namespace classCreation
{
    class banking_app
    {
        public string Number { get; }
        public string Owner { get; set; }
        public string AvailableBalance { get; }

        public void CheckBalance(string Owner, string AvailableBalance)
        {

            Console.WriteLine("Dear {0}, your balance is {1}", Owner, AvailableBalance);
        }
        public void ConfirmAccountNumber()
        {
            Console.WriteLine("Dear {0}, Your account number is {1}", Owner, Number);
        }
    }
}
