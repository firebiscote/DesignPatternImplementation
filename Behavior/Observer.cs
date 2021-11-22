/*Le patron de conception observateur/observable est utilisé 
 * en programmation pour envoyer un signal à des modules qui 
 * jouent le rôle d'observateur. En cas de notification, les 
 * observateurs effectuent alors l'action adéquate en fonction 
 * des informations qui parviennent depuis les modules qu'ils
 * observent (les "observables"). Dans ce patron de conception,
 * l'objet observé maintient une liste d'observateurs et les 
 * notifient automatiquement de tout changement d'état, 
 * généralement en appelant une de leur méthode.
 */

using System;

namespace DesignPatternImplementation.Behavior
{
    public class Observer
    {
        public void Reception(object sender, EventArgs e)
        {
            Console.WriteLine("Receive " + e.ToString() + "from " + sender.ToString());
        }
    }

    public class Implementation
    {
        public static event EventHandler Observable;

        public static void Process()
        {
            Observer test = new Observer();

            Observable += new EventHandler(test.Reception);

            if (Observable != null)
                Observable(AppDomain.CurrentDomain, new TestEventArgs() { Things = 0 });
        }
    }

    public class TestEventArgs : EventArgs
    {
        public uint Things;

        public override string ToString()
        {
            return ((Things > 0) ? Things.ToString() : "no more") + " bottle" + ((Things > 1) ? "s" : string.Empty);
        }
    }
}
