using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITesting.Model;
using APITesting.Services;
using Microsoft.AspNetCore.Components;

namespace APITesting.Pages
{
    public partial class Pokemon
    {
        [Inject]
        ApiService apiService { get; set; }

        PokemonModel PokemonDetails = new();

        
        string name = "ditto";

        protected override void OnInitialized()
        {
            GetPokemon();
            base.OnInitialized();
        }

        public async void GetPokemon()
        {
            PokemonDetails = await apiService.GetPokemonDetails(name);
            StateHasChanged();
        }
    }
}