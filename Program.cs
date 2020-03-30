using System;
using PackagePrivate;
using Newtonsoft.Json;

namespace ConsumePackage
{
    public class Program
    {
        static void Main(string[] args)
        {
            string json = $"{{ 'who': '{Greeted.Who}' }}";

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
