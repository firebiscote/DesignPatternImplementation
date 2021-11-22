/* Le patron mémento est un patron de conception qui fournit 
 * la manière de renvoyer un objet à un état précédent 
 * (retour arrière) sans violer le principe d'encapsulation.
 */

/* Mémento est un patron de conception comportemental qui 
 * permet de sauvegarder et de rétablir l’état précédent d’un 
 * objet sans révéler les détails de son implémentation.
 * 
 * Complexité 3/3
 * Popularité 1/3
 * 
 * Le principe du mémento peut être imité en utilisant la sérialisation, 
 * ce qui est assez commun en C#. Ce n’est pas forcément la manière 
 * la plus efficace de prendre des instantanés de l’état d’un objet, 
 * mais il permet de stocker des sauvegardes de l’état tout en protégeant 
 * la structure du créateur des autres objets.
 */

using System.Collections.Generic;

namespace DesignPatternImplementation.Behavior.Memento
{
    public class Originator
    {
        public string State { get; set; }

        public object SaveToMemento()
        {
            return new Memento(State);
        }

        public void RestoreFromMemento(object obj)
        {
            if (obj.GetType().ToString() == "Memento")
            {
                Memento memento = (Memento)obj;
                State = memento.State;
            }
        }

        private class Memento
        {
            public string State { get; }

            public Memento(string state)
            {
                this.State = state;
            }
        }
    }

    public class Caretaker
    {
        private List<object> savedStates = new List<object>();

        public void AddMemento(object memento) 
        { 
            savedStates.Add(memento); 
        }

        public object GetMemento(int index) 
        { 
            return savedStates[index]; 
        }
    }
}
