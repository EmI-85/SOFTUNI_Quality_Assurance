namespace Problem04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  

            Dictionary <string, Trainer> trainers = new Dictionary<string, Trainer>();

            while(input != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                string[] inputData = input.Split();

                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElement = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);

               if(!trainers.ContainsKey(trainerName))
               {
                    var trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
               }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainers[trainerName].Pokemons.Add(pokemon);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "End")
            {
                foreach (var (key, trainer) in trainers)
                {
                    if(trainer.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        foreach(var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var (key, trainer) in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{key} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }
    }
}
