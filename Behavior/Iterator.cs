/* Un itérateur ressemble à un pointeur disposant essentiellement 
 * de deux primitives : accéder à l'élément pointé en cours 
 * (dans le conteneur), et se déplacer pour pointer vers l'élément 
 * suivant. En sus, il faut pouvoir créer un itérateur pointant 
 * sur le premier élément ; ainsi que déterminer à tout moment 
 * si l'itérateur a épuisé la totalité des éléments du conteneur. 
 * Diverses implémentations peuvent également offrir des comportements 
 * supplémentaires.
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

namespace DesignPatternImplementation.Behavior.Iterator
{
    public interface IEnumerator
    {
        public void Reset();
        public bool MoveNext();
        public Object Current { get; }
    }
}
