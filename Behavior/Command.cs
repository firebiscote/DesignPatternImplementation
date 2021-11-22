/*Commande est un patron de conception de type comportemental 
 * qui encapsule la notion d'invocation. Il permet de séparer 
 * complètement le code initiateur de l'action, du code de 
 * l'action elle-même. Ce patron de conception est souvent 
 * utilisé dans les interfaces graphiques où, par exemple, 
 * un item de menu peut être connecté à différentes Commandes 
 * de façons à ce que l'objet d'item de menu n'ait pas besoin 
 * de connaître les détails de l'action effectuée par la Commande.
 */

using System;

namespace DesignPatternImplementation.Behavior.Command
{
    public class Switch
    {
        private ICommand flipUpCommand;
        private ICommand flipDownCommand;

        public Switch(ICommand flipUpCommand, ICommand flipDownCommand)
        {
            this.flipDownCommand = flipDownCommand;
            this.flipUpCommand = flipUpCommand;
        }

        public void FlipUp()
        {
            flipUpCommand.Execute();
        }

        public void FlipDown()
        {
            flipDownCommand.Execute();
        }
    }

    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("The light is on !");
        }

        public void TurnOff()
        {
            Console.WriteLine("The light is off !");
        }
    }

    public interface ICommand
    {
        public void Execute();
    }

    public class TurnOnCommand : ICommand
    {
        private Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    public class TurnOffCommand : ICommand
    {
        private Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }
}
