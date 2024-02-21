using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITesting.Model
{
    public class PokemonModel
    {
        public string name { get; set; }
        public int id { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public bool is_default { get; set; }

        public PokemonSprite sprites { get; set; }
    }
}