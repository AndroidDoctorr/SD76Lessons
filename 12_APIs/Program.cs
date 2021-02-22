using _12_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs
{
    class Program
    {
        static void Main(string[] args)
        {
            SWAPIService service = new SWAPIService();
            SWAPIUI UI = new SWAPIUI(service);

            UI.Run();




            // HyperText Transfer Protocol
            // HTML = HyperText Markup Language

            HttpClient httpClient = new HttpClient();

            HttpResponseMessage response = httpClient.GetAsync("https://swapi.dev/api/people/5/").Result;

            // Async means it's happening asynchronously
            // (on another timeline)

            if (response.IsSuccessStatusCode)
            {
                // ReadAsString gives us the raw JSON string
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            }

            // ReadAsAsync converts the JSON to C# (POCO)
            Person person = response.Content.ReadAsAsync<Person>().Result;

            HttpResponseMessage planetResponse = httpClient.GetAsync(person.Homeworld).Result;

            if (planetResponse.IsSuccessStatusCode)
            {
                // POCO = plain old C# object
                Planet planet = planetResponse.Content.ReadAsAsync<Planet>().Result;

                Console.WriteLine($"\n\n{person.Name} is {person.Height}cm tall and has {person.Eye_Color} eyes. {person.Name} is from the {planet.Climate} world of {planet.Name}.");
            } else
            {
                Console.WriteLine($"\n\n{person.Name} is {person.Height}cm tall and has {person.Eye_Color} eyes.");
            }
        }
    }
}
