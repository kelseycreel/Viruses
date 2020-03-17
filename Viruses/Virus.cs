using System;
using System.Collections.Generic;
using System.Text;

namespace Viruses
{
    class Virus
    {
        // properties are uppercase, variables are camelcase, and fields start with underscore
        public string Name { get; set; }
        public List<string> Symptoms { get; set; }
        public int NumberOfDeaths { get; set; }
        public int IncubationDays { get; set; }

        public Virus(string name, int incubationDays)
        {
            Name = name;
            IncubationDays = incubationDays;
            Symptoms = new List<string>();
        }
    }
}
