/* Le patron stratégie est un patron de conception de type comportemental 
 * grâce auquel des algorithmes peuvent être sélectionnés à la volée au 
 * cours de l'exécution selon certaines conditions, comme les stratégies 
 * utilisées en temps de guerre.
 */

/* Stratégie est un patron de conception comportemental qui permet de définir 
 * une famille d’algorithmes, de les mettre dans des classes séparées et de 
 * rendre leurs objets interchangeables.
 * 
 * Complexité 1/3
 * Popularité 3/3
 * 
 * Le patron de conception stratégie est très répandu en C#. Il est souvent 
 * utilisé dans divers frameworks pour fournir aux utilisateurs la possibilité 
 * de modifier le comportement d’une classe sans l’étendre.
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
