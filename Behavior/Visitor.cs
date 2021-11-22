/* Le visiteur est une manière de séparer un algorithme d'une structure 
 * de données. Un visiteur possède une méthode par type d'objet traité. 
 * Pour ajouter un nouveau traitement, il suffit de créer une nouvelle 
 * classe dérivée de la classe Visiteur. On n'a donc pas besoin de 
 * modifier la structure des objets traités, contrairement à ce qu'il 
 * aurait été obligatoire de faire si on avait implémenté les traitements 
 * comme des méthodes de ces objets.
 */

/* Visiteur est un patron de conception comportemental qui vous permet de 
 * séparer les algorithmes et les objets sur lesquels ils opèrent.
 * 
 * Complexité 3/3
 * Popularité 1/3
 * 
 * Le visiteur n’est pas un patron très répandu en C# à cause de sa 
 * complexité et de la rareté de ses cas d’utilisation.
 */

using System;

namespace DesignPatternImplementation.Behavior
{
    public interface ICarElementVisitor
    {
        public void Visit(Wheel wheel);
        public void Visit(Engine engine);
        public void Visit(Body body);
        public void Visit(Car car);
    }

    public interface ICarElement
    {
        public void Accept(ICarElementVisitor visitor);
    }

    public class Wheel : ICarElement
    {
        public string Name { get; set; }

        public Wheel(string name)
        {
            this.Name = name;
        }

        void ICarElement.Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Engine : ICarElement
    {
        void ICarElement.Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Body : ICarElement
    {
        void ICarElement.Accept(ICarElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Car
    {
        public ICarElement[] Elements { get; }

        public Car()
        {
            this.Elements = new ICarElement[]
            {
                new Wheel("front left"),
                new Wheel("front right"),
                new Wheel("back left"),
                new Wheel("back right"),
                new Body(),
                new Engine()
            };
        }
    }

    public class CarElementPrintVisitor : ICarElementVisitor
    {
        void ICarElementVisitor.Visit(Wheel wheel)
        {
            Console.WriteLine("Visiting " + wheel.Name + " wheel");
        }

        void ICarElementVisitor.Visit(Engine engine)
        {
            Console.WriteLine("Visiting engine");
        }

        void ICarElementVisitor.Visit(Body body)
        {
            Console.WriteLine("Visiting body");
        }

        void ICarElementVisitor.Visit(Car car)
        {
            Console.WriteLine("\nVisiting car");
            foreach (ICarElement element in car.Elements)
            {
                element.Accept(this);
            }
            Console.WriteLine("Car visited");
        }
    }

    public class CarElementDoVisitor : ICarElementVisitor
    {
        void ICarElementVisitor.Visit(Wheel wheel)
        {
            Console.WriteLine("Do with wheel");
        }

        void ICarElementVisitor.Visit(Engine engine)
        {
            Console.WriteLine("Do with engine");
        }

        void ICarElementVisitor.Visit(Body body)
        {
            Console.WriteLine("Do with body");
        }

        void ICarElementVisitor.Visit(Car car)
        {
            Console.WriteLine("\nStarting my car");
            foreach (ICarElement element in car.Elements)
            {
                element.Accept(this);
            }
            Console.WriteLine("Car started");
        }
    }
}
