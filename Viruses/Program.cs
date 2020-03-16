using System;
using System.Collections.Generic;

namespace Viruses
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
