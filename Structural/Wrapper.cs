/* Adaptateur est un patron de conception qui permet de 
 * convertir l'interface d'une classe en une autre interface 
 * que le client attend. Adaptateur fait fonctionner un 
 * ensemble de classes qui n'auraient pas pu fonctionner 
 * sans lui, à cause d'une incompatibilité d'interfaces.
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

namespace DesignPatternImplementation.Structural.Wrapper
{
    public interface IDeveloper
    {
        string Code();
    }

    public class ClassicDeveloper : IDeveloper
    {
        string IDeveloper.Code()
        {
            return "some code";
        }
    }

    public class Architect
    {
        public string WriteAlgorithm()
        {
            return "some algo";
        }
    }

    public class Wrapper : IDeveloper
    {
        private Architect architect;

        public Wrapper(Architect architect)
        {
            this.architect = architect;
        }

        string IDeveloper.Code()
        {
            return "some code " + architect.WriteAlgorithm();
        }
    }
}
