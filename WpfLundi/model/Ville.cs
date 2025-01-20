using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLundi.model
{
    public class Ville
    {
        String? nom;
        //int? population;
        String? pays;

        public Ville(string? nom, int? population, string? pays)
        {
            this.Nom = nom;
            this.Population = population;
            this.Pays = pays;
        }
        public String? Nom { get => nom; set => nom = value.Trim().ToUpper(); }
        public int? Population { get; set; }
        public String? Pays { get => pays; set => pays = value.Trim().Substring(0,1).ToUpper() + value.Trim().Substring(1).ToLower(); }
    }
}
