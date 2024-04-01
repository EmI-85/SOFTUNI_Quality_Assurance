using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    public class Trainer
    {
        public Trainer()
        {
            this.Pokemons = new List<Pokemon>();
        }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List <Pokemon> Pokemons {  get; set; }

    }
}
