/* Dans ce patron de conception, un objet composite est 
 * constitué d'un ou de plusieurs objets similaires 
 * (ayant des fonctionnalités similaires). 
 * L'idée est de manipuler un groupe d'objets de la même 
 * façon que s'il s'agissait d'un seul objet. Les objets 
 * ainsi regroupés doivent posséder des opérations communes, 
 * c'est-à-dire un "dénominateur commun".
 */

/* Composite est un patron de conception structurel qui permet 
 * d’agencer les objets dans des arborescences afin de pouvoir 
 * traiter celles-ci comme des objets individuels.
 * 
 * Complexité 2/3
 * Popularité 2/3
 * 
 * Le composite est très répandu en C#. Il est souvent utilisé 
 * pour modéliser les hiérarchies des composants d’une interface 
 * utilisateur ou pour du code qui manipule des graphes.
 */

using System;

namespace DesignPatternImplementation.Structural.Composite
{
    public abstract class Component
    {
        public int Level = 0;
        public string Name;

        public virtual void Draw()
        {
            for (int i = 0; i < Level; i++)
                Console.Write("\t");
        }
    }

    public class Sheet : Component
    {
        public override void Draw()
        {
            Console.WriteLine("Sheet : " + Name);
        }
    }

    public class Composite : Component
    {
        public Component[] Components;

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Composite : " + Name);
            foreach (Component component in Components)
            {
                component.Level = this.Level + 1;
                component.Draw();
            }
        }
    }
}
