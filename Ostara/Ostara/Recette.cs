using System;
using System.Collections.Generic;
using System.Text;

namespace Ostara
{
    public class Recette
    {
        public string Nom { get; }
        public int Parts { get; }
        public string Type { get; }
        public string Seasons { get; }
        public string Products { get; }
        public string Description { get; }
        public string Instructions { get; }

        public Recette(string name, int parts, string typeOfRe, string seasonsPossible,string products, string descriptionParam,
            string instructionsParam)
        {
            Nom = name;
            Parts = parts;
            Type = typeOfRe;
            Seasons = seasonsPossible;
            Description = descriptionParam;
            Products = products;
            Instructions = instructionsParam;
        }
    }
}
