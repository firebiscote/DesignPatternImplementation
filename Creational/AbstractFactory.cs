/*Une fabrique abstraite encapsule un groupe de fabriques ayant une 
 * thématique commune. Le code client crée une implémentation concrète 
 * de la fabrique abstraite, puis utilise les interfaces génériques pour 
 * créer des objets concrets de la thématique. Le client ne se préoccupe 
 * pas de savoir laquelle de ces fabriques a donné un objet concret, car 
 * il n'utilise que les interfaces génériques des objets produits. 
 * Ce patron de conception sépare les détails d'implémentation d'un 
 * ensemble d'objets de leur usage générique.
 */

using System;

namespace DesignPatternImplementation.Creational.AbstractFactory
{
    public abstract class LifeFactory
    {
        public static LifeFactory GetFactory(string type)
        {
            return (type.ToLower()) switch
            {
                "feline" => FelineFactory.GetFactory(),
                "canine" => CanineFactory.GetFactory(),
                _ => throw new Exception(type + " didn't exist !")
            };
        }
    }

    public class FelineFactory : LifeFactory
    {
        private static FelineFactory instance = new FelineFactory();

        private FelineFactory() { }
        public static FelineFactory GetFactory()
        {
            return instance;
        }
        public IAnimal GetFeline(string type)
        {
            return (type.ToLower()) switch
            {
                "cat" => new Cat(),
                _ => throw new Exception(type + " didn't exist !"),
            };
        }
    }

    public class CanineFactory : LifeFactory
    {
        private static CanineFactory instance = new CanineFactory();

        private CanineFactory() { }
        public static CanineFactory GetFactory()
        {
            return instance;
        }
        public IAnimal GetCanine(string type)
        {
            return (type.ToLower()) switch
            {
                "dog" => new Cat(),
                _ => throw new Exception(type + " didn't exist !"),
            };
        }
    }

    public interface IAnimal
    {
        public void MyName();
    }

    public class Cat : IAnimal
    {
        void IAnimal.MyName()
        {
            Console.WriteLine("I'm a cat !");
        }
    }

    public class Dog : IAnimal
    {
        void IAnimal.MyName()
        {
            Console.WriteLine("I'm a dog !");
        }
    }
}
