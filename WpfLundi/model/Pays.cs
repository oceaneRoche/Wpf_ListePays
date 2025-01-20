using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLundi.model
{
    public class Pays : ObservableCollection<String>
    {
        public Pays()
        {
            Add("Bangladesh");
            Add("Brésil");
            Add("Chine");
            Add("Egypte");
            Add("France");
            Add("Inde");
            Add("Japon");
            Add("Mexique");
        }
    }
}
