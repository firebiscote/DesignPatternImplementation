/* Commande est un patron de conception de type comportemental 
 * qui encapsule la notion d'invocation. Il permet de séparer 
 * complètement le code initiateur de l'action, du code de 
 * l'action elle-même. Ce patron de conception est souvent 
 * utilisé dans les interfaces graphiques où, par exemple, 
 * un item de menu peut être connecté à différentes Commandes 
 * de façons à ce que l'objet d'item de menu n'ait pas besoin 
 * de connaître les détails de l'action effectuée par la Commande.
 */

/* Commande est un patron de conception comportemental qui prend une 
 * action à effectuer et la transforme en un objet autonome qui contient 
 * tous les détails de cette action. Cette transformation permet de 
 * paramétrer des méthodes avec différentes actions, planifier leur exécution, 
 * les mettre dans une file d’attente ou d’annuler des opérations effectuées.
 * 
 * Complexité 1/3
 * Popularité 3/3
 * 
 * La commande est très répandue en C#. Elle est souvent utilisée comme une 
 * alternative aux callbacks pour paramétrer les éléments d’une UI avec des actions. 
 * Elle est également utilisée pour mettre des tâches dans une file d’attente, 
 * suivre un historique de traitements, etc.
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
