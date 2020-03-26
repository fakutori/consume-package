using System;
using Newtonsoft.Json;

namespace Prey
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = @"{ 'who': 'World' }";

            var who = FindTargetPerson(json);

            Console.WriteLine($"Hello, {who}!");
        }

        public static string FindTargetPerson(string json)
        {
            var payload = JsonConvert.DeserializeObject<HelloPayload>(json);
            return payload.Who;
        }
    }

    public class HelloPayload
    {
        public string Who { get; set; }
    }
}
