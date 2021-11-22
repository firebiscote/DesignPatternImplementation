/*Le patron poids-mouche est l'approche pour utiliser de telles classes. 
 * D'une part la classe avec ses données internes qui la rendent unique, 
 * et d'autre part les données externes passées à la classe en tant qu'arguments. 
 * Ce modèle est très pratique pour des petites classes très simples. 
 * Par exemple pour représenter des caractères ou des icônes à l'écran, 
 * ce type de patron de conception est apprécié. Ainsi, chaque caractère 
 * peut être représenté par une instance d'une classe contenant sa police, 
 * sa taille, etc. La position des caractères à afficher est stockée 
 * en dehors de cette classe. Ainsi, on a une et une seule instance 
 * de la classe par caractère et non une instance par caractère affiché 
 * à l'écran.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternImplementation.Structural.FlyWeight
{
    public class Flyweight
    {
        private Car sharedState;

        public Flyweight(Car car)
        {
            this.sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            Console.WriteLine(sharedState.Model + " " + uniqueState.Model);
        }
    }

    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new List<Tuple<Flyweight, string>>();

        public FlyweightFactory(params Car[] args)
        {
            foreach (var elem in args)
            {
                flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(elem), this.GetKey(elem)));
            }
        }

        public string GetKey(Car key)
        {
            List<string> elements = new List<string>();
            elements.Add(key.Model);
            elements.Add(key.Color);
            elements.Add(key.Company);
            if (key.Owner != null && key.Number != null)
            {
                elements.Add(key.Number);
                elements.Add(key.Owner);
            }
            elements.Sort();
            return string.Join("_", elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = this.GetKey(sharedState);
            if (flyweights.Where(t => t.Item2 == key).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                this.flyweights.Add(new Tuple<Flyweight, string>(new Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.Where(t => t.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
        }
    }

    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Company { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
    }
}