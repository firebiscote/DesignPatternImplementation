/* Un itérateur ressemble à un pointeur disposant essentiellement 
 * de deux primitives : accéder à l'élément pointé en cours 
 * (dans le conteneur), et se déplacer pour pointer vers l'élément 
 * suivant. En sus, il faut pouvoir créer un itérateur pointant 
 * sur le premier élément ; ainsi que déterminer à tout moment 
 * si l'itérateur a épuisé la totalité des éléments du conteneur. 
 * Diverses implémentations peuvent également offrir des comportements 
 * supplémentaires.
 */

/* Itérateur est un patron de conception comportemental qui permet de 
 * parcourir les éléments d’une collection sans révéler sa représentation 
 * interne (liste, pile, arbre, etc.).
 * 
 * Complexité 2/3
 * Popularité 3/3
 * 
 * L’itérateur est très répandu en C#. Il est utilisé dans de nombreux 
 * frameworks et bibliothèques pour fournir une méthode de parcours standard 
 * de leurs collections.
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
