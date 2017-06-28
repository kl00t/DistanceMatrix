namespace DistanceMatrix.ConsoleApplication
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class Program
    {
        static void Main(string[] args)
        {
            var json = @"{
               'Email': 'james@example.com',
               'Active': true,
               'CreatedDate': '2013-01-20T00:00:00Z',
               'Roles': [
                 'User',
                 'Admin'
               ]
             }";

            var account = JsonConvert.DeserializeObject<Account>(json);
            Console.WriteLine(account.Email);
            Console.ReadLine();
        }
    }

    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}