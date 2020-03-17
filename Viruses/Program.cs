using System;
using System.Collections.Generic;

namespace Viruses
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST
            // create a list of strings
            var names = new List<string>();

            // add items to the list one item at a time
            names.Add("COVID-19");
            names.Add("Ebola");
            names.Add("Spanish Flu");
            names.Add("SARS");
            names.Add("Rabies");
            names.Add("Stupidity");

            // remove items from the list one item at a time
            names.Remove("Stupidity");

            // remove the thing at index 3
            // names.RemoveAt(3);

            // insert at specific location
            names.Insert(0, "HIV");

            // add multiple items at once or COLLECTION INITIALIZER
            var people = new List<string>() {"Nathan", "Martin", "Kelsey", "Monica"};

            // combining two lists together
            names.AddRange(people);

            // remove multiple items
            // Length is not a proprty on lists, use count instead
            names.RemoveRange(names.Count - 4, 4);

            foreach (var name in names)
            {
                Console.WriteLine($"current name is {name}");
            }

            //------------------------------------------------------------------------------
            // DICTIONARIES
            // specialized type of collection
            // dictionaries needs a key and a value input
            // lists' key equivalent are their index, you get to choose the key in the dictionaries
            // can't add more than one item with the same key

            // create dictionary
            var symptoms = new Dictionary<string, string>();

            // add single item
            // key is first input, value is second input
            symptoms.Add("COVID-19", "dry cough, fever, difficulty breathing");
            symptoms.Add("Ebola", "fever, headache, muscle pain, chills");
            symptoms.Add("Spanish Flu", "fever, nausea, aches and diarrhea");
            symptoms.Add("SARS", "fever, dry cough, headache, muscle aches, and difficulty breathing");
            symptoms.Add("Rabies", "fever, headache, excess salivation, muscle spasms, paralysis");

            // get single thing from dictionary
            var covidSymptons = symptoms["COVID-19"];

            // remove single item
            symptoms.Remove("Ebola");

            // collection initializer
            var peopleDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 } };


            // these 2 foreaches will print the same thing, but 2 different ways to achieve it
            foreach (var (key,value) in symptoms)
            {
                //symptom is a keyvalue pair
                //doing the vars key,value creates variables to hold the keys and values of each symptom in the loop
                //a good idea in this case, would be to name them virus, symptom so we know what the hell they are
                Console.WriteLine($"the {key} virus has the following symptoms: {value}");
            }

            foreach (var name in names)
            {
                if (symptoms.ContainsKey(name))
                    Console.WriteLine($"The {name} virus has the following symptoms: {symptoms[name]}");
                else
                    Console.WriteLine($"The {name} virus is unknown...");
            }

            //------------------------------------------------------------------------------
            // QUEUES
            // collection of things and ability to pull them out one at a time and not be in the collection anymore
            // queues have special methods

            var diseasesToCure = new Queue<string>();

            // instead of add
            diseasesToCure.Enqueue("COVID-19");
            diseasesToCure.Enqueue("SARS");

            // instead of remove
            // first in, first out FIFO -- it will dequeue them in the order they were added, like a real queue and put the item into a variable
            // stacks (a different type of collection) are last in, first out LIFO
            var thingToCure = diseasesToCure.Dequeue();
            var nextThingToCure = diseasesToCure.Dequeue();


            //------------------------------------------------------------------------------
            // HASHSET
            // good for low write and heavy read operations

            var vectors = new HashSet<string>();

            // will not add a duplicate value, will just skip it
            // FYI -- a list will add the duplicate value
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");
            vectors.Add("Airborne");
            vectors.Add("Droplet");
            vectors.Add("Bloodborne");

            //--------------------------------------------------------
            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry cough");
            covid19.Symptoms.Add("Difficulty breathing");
            covid19.NumberOfDeaths = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry cough");
            spanishFlu.Symptoms.Add("Difficulty breathing");
            spanishFlu.NumberOfDeaths = 50000000;

            var rabies = new Virus("rabies", 11);
            rabies.Symptoms.Add("Excess salivation");
            rabies.Symptoms.Add("Dry cough");
            rabies.NumberOfDeaths = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and {virus.NumberOfDeaths} number of wombat deaths");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }

        }
    }
}
