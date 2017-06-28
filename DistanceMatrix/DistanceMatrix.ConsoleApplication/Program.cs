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
               'Bar': 'Foobar',
               'Active': true,
               'CreatedDate': '2013-01-20T00:00:00Z'
             }";

            var foo = JsonConvert.DeserializeObject<Foo>(json);
            Console.WriteLine(foo.Bar);
            Console.ReadLine();
        }
    }

    public class Foo
    {
        public string Bar { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}