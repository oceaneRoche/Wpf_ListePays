using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLundi.model
{
    internal class LesVilles : ObservableCollection<Ville>
    {
        public LesVilles()
        {
            Add(new Ville("Tokyo", 37194104, "Japon"));
            Add(new Ville("Delhi", 32941308, "Inde"));
            Add(new Ville("Shangai", 29210808, "Chine"));
            Add(new Ville("Dhaka", 23209616, "Bangladesh"));
            Add(new Ville("Sao Paulo", 22619736, "Brésil"));
            Add(new Ville("Mexico", 22281442, "Mexique"));
            Add(new Ville("Le Caire", 22183200, "Egypte"));
            Add(new Ville("Pékin", 21766214, "Bangladesh"));
            Add(new Ville("Bombay", 21296516, "Inde"));


        }
    }
}
