/*Le patron poids-mouche est l'approche pour utiliser de telles classes. 
 * D'une part la classe avec ses données internes qui la rendent unique, 
 * et d'autre part les données externes passées à la classe en tant qu'arguments. 
 * Ce modèle est très pratique pour des petites classes très simples. 
 * Par exemple pour représenter des caractères ou des icônes à l'écran, 
 * ce type de patron de conception est apprécié. Ainsi, chaque caractère 
 * peut être représenté par une instance d'une classe contenant sa police, 
 * sa taille, etc. La position des caractères à afficher est stockée 
 * en dehors de cette classe. Ainsi, on a une et une seule instance 
 * de la classe par caractère et non une instance par caractère affiché 
 * à l'écran.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternImplementation.Structural
{
    class Flyweight
    {
    }
}
