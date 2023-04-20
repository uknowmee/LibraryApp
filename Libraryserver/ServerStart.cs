using System;
using BookManagement;
using BooksView;
using CurrencyCalculator;
using DbBuilder;
using Login;
using Notifications;
using Register;
using Rent;
using Subscriptions;

namespace LibraryServer
{
    internal static class ServerStart
    {
        static void Main(string[] args)
        {
            BuildDatabaseIfNeeded();

            StartServices();

            Console.WriteLine("Press <Enter> to terminate the service.");
            Console.WriteLine();
            Console.ReadLine();

            CloseServices();
        }

        private static void BuildDatabaseIfNeeded()
        {
            DbBuilderRun.Start();

            MakeDb.ShouldMakeDb();
        }

        private static void StartServices()
        {
            BookManagementRun.Start();
            BooksViewRun.Start();
            CurrencyCalculatorRun.Start();
            LoginRun.Start();
            NotificationsRun.Start();
            RegisterRun.Start();
            RentRun.Start();
            SubscriptionsRun.Start();
        }

        private static void CloseServices()
        {
            BookManagementRun.End();
            BooksViewRun.End();
            CurrencyCalculatorRun.End();
            LoginRun.End();
            NotificationsRun.End();
            RegisterRun.End();
            RentRun.End();
            SubscriptionsRun.End();
            DbBuilderRun.End();
        }
    }
}
