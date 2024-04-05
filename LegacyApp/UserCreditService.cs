using System;
using System.Collections.Generic;
using System.Threading;

namespace LegacyApp
{
    public class UserCreditService : IDisposable, IUserCreditService
    {
        private readonly Dictionary<string, int> _database =
            new Dictionary<string, int>()
            {
                {"Kowalski", 200},
                {"Malewski", 20000},
                {"Smith", 10000},
                {"Doe", 3000},
                {"Kwiatkowski", 1000}
            };
        
        public void Dispose()
        {
        }

        public int GetCreditLimit(string lastName, DateTime dateOfBirth)
        {
            Thread.Sleep(new Random().Next(3000)); // Symulacja opóźnienia z serwisu zewnętrznego

            if (_database.ContainsKey(lastName))
            {
                return _database[lastName];
            }

            throw new ArgumentException($"Klient o nazwisku {lastName} nie istnieje.");
        }
    }
}