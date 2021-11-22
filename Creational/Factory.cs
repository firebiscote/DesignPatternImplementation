/*La fabrique (factory) est un patron de conception de création utilisé 
 * en programmation orientée objet. Comme les autres modèles de création, 
 * la fabrique a pour rôle l'instanciation d'objets divers dont le type 
 * n'est pas prédéfini : les objets sont créés dynamiquement en fonction 
 * des paramètres passés à la fabrique.
 */

/* Complexité 1/3
 * Popularité 3/3
 * Fabrique est un patron de conception de création qui définit 
 * une interface pour créer des objets dans une classe mère, 
 * mais délègue le choix des types d’objets à créer aux sous-classes.
 */

using System;

namespace DesignPatternImplementation.Creational.Factory
{
    public class AnimalFactory
    {
        private static AnimalFactory instance = new AnimalFactory();

        private AnimalFactory() { }

        public static AnimalFactory GetAnimalFactory()
        {
            return instance;
        }

        public IAnimal GetAnimal(string type)
        {
            return (type.ToLower()) switch
            {
                "cat" => new Cat(),
                "dog" => new Dog(),
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
