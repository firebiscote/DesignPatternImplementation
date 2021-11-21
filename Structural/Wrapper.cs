/*Adaptateur est un patron de conception qui permet de 
 * convertir l'interface d'une classe en une autre interface 
 * que le client attend. Adaptateur fait fonctionner un 
 * ensemble de classes qui n'auraient pas pu fonctionner 
 * sans lui, à cause d'une incompatibilité d'interfaces.
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
