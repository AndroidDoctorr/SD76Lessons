using _12_APIs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _12_APIs
{
    public class SWAPIService
    {
        private HttpClient _client;

        public SWAPIService()
        {
            _client = new HttpClient();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"https://swapi.dev/api/people/{id}/");

            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            return new Person() { Name = "Nemo" };
            // or return null
        }

        public async Task<Planet> GetPlanetAsync(int id)
        {
            HttpResponseMessage response = await _client.GetAsync($"https://swapi.dev/api/planets/{id}/");
            if (response.IsSuccessStatusCode)
            {
                Planet planet = await response.Content.ReadAsAsync<Planet>();
                return planet;
            }

            return new Planet() { Name = "Pouthená" };
        }

        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            return default;
        }

        public async Task<SearchResult<T>> SearchAsync<T>(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return default;
        }

        public async Task<SearchResult<Person>> SearchPeopleAsync(string query)
        {
            HttpResponseMessage response = await _client.GetAsync($"https://swapi.dev/api/people/?search={query}");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }

            return new SearchResult<Person>();
        }


        public async Task<SearchResult<T>> SearchAsync<T>(string table, string query)
        {
            HttpResponseMessage response = await _client.GetAsync($"https://swapi.dev/api/{table}/?search={query}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }

            return new SearchResult<T>();
        }

        public async Task<SearchResult<Starship>> SearchStarshipsAsync(string query)
        {
            return await SearchAsync<Starship>("starships", query);
        }

        public async Task<SearchResult<Planet>> SearchPlanetsAsync(string query)
        {
            return await SearchAsync<Planet>("planets", query);
        }
    }
}
