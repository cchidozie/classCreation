﻿using System;


namespace classCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            banking_app account = new banking_app();

            account.CheckBalance("dozie", "5000");

            Console.ReadLine();

        }
    }
}
