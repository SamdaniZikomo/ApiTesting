using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using APITesting.Model;

namespace APITesting.Services
{
    public class ApiService
    {
        readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PokemonModel> GetPokemonDetails(string name)
        {
            var result = await _httpClient.GetFromJsonAsync<PokemonModel>($"https://pokeapi.co/api/v2/pokemon/{name}");
            return result;
        }
    }
}