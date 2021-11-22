/* Le patron stratégie est un patron de conception de type comportemental 
 * grâce auquel des algorithmes peuvent être sélectionnés à la volée au 
 * cours de l'exécution selon certaines conditions, comme les stratégies 
 * utilisées en temps de guerre.
 */

/* L’Adaptateur est un patron de conception structurel qui 
 * permet de faire collaborer des objets ayant des 
 * interfaces normalement incompatibles.
 * 
 * Complexité 1/3
 * Popularité 3/3
 * 
 * L’adaptateur est très répandu en C#. On le retrouve 
 * souvent dans des systèmes basés sur du code hérité, 
 * dans lesquels l’adaptateur fait fonctionner du code 
 * hérité avec des classes modernes.
 */

using System;

namespace DesignPatternImplementation.Behavior.Strategy
{
    public interface IStrategy
    {
        public void Execute();
    }

    public class AlgorithmA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("A");
        }
    }

    public class AlgorithmB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("B");
        }
    }

    public class Element
    {
        private IStrategy strategy;

        public Element(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}
