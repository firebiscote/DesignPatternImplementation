/*Un itérateur ressemble à un pointeur disposant essentiellement 
 * de deux primitives : accéder à l'élément pointé en cours 
 * (dans le conteneur), et se déplacer pour pointer vers l'élément 
 * suivant. En sus, il faut pouvoir créer un itérateur pointant 
 * sur le premier élément ; ainsi que déterminer à tout moment 
 * si l'itérateur a épuisé la totalité des éléments du conteneur. 
 * Diverses implémentations peuvent également offrir des comportements 
 * supplémentaires.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternImplementation.Behavior
{
    public interface IEnumerator
    {
        public void Reset();
        public bool MoveNext();
        public Object Current { get; }
    }
}
