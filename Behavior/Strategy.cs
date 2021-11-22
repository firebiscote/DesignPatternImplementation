/*Le patron stratégie est un patron de conception de type comportemental 
 * grâce auquel des algorithmes peuvent être sélectionnés à la volée au 
 * cours de l'exécution selon certaines conditions, comme les stratégies 
 * utilisées en temps de guerre.
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
