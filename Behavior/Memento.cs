/* Le patron mémento est un patron de conception qui fournit 
 * la manière de renvoyer un objet à un état précédent 
 * (retour arrière) sans violer le principe d'encapsulation.
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
