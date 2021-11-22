/*Le patron mémento est un patron de conception qui fournit 
 * la manière de renvoyer un objet à un état précédent 
 * (retour arrière) sans violer le principe d'encapsulation.
 */

using System.Collections.Generic;

namespace DesignPatternImplementation.Structural.Memento
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
