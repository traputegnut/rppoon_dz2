using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srp
{
    class FileManager   /* problem u ovoj klasi je sto imamo tri funkcije koje su slicne,ali sve tri su cvrste vezane
                         * uz klasu FileManger.Pravilno bi bilo napravit interface za svaku pojedinu funkciju te bi onda 
                         klasa kojoj je potrebna pojedina funkcija nasljedila potreban interface.Labava veza*/
    {
        public void SaveFile() { }
        public void DeleteFile() { }
        public void AddNewFile() { }
    }
}
