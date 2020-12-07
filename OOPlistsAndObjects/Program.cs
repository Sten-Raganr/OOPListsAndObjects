using System;
using System.Collections.Generic;
using System.IO;

namespace OOPlistsAndObjects
{
    class Program
    {
        class Planet
        {
            string name;
            int mass;

            public Planet(string _name,int _mass)
            {
                name = _name;
                mass = _mass;
            }
            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        class Listofplanets
        {
            List<Planet> planets;
            int totalmass;
            public Listofplanets()
            {
                planets = new List<Planet>();
                totalmass = 0;
            }
            public void AddPlanettolist(string planetname, int planetmass)
            {
                Planet newplanet = new Planet(planetname, planetmass);
                planets.Add(newplanet);
            }
            public void PrintPlanets()
            {
                foreach(Planet planetsfromlists in planets)
                {
                    Console.WriteLine($"Planet:{planetsfromlists.Name}; Mass:{planetsfromlists.Mass}");
                }
            }
        }
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilane\Samples";
            string filename = @"planets.txt";
            string fullpath = Path.Combine(filepath, filename);

            string[] planetsfromfile = File.ReadAllLines(fullpath);

            foreach(string line in planetsfromfile)
            {
                string[] tempArray = line.Split(new char[] { '$'}, StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
