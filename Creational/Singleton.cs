/* Le singleton est un patron de conception dont l'objet est de restreindre 
 * l'instanciation d'une classe à un seul objet (ou bien à quelques objets seulement). 
 * Il est utilisé lorsque l'on a besoin d'exactement un objet pour coordonner des 
 * opérations dans un système. Le modèle est parfois utilisé pour son efficacité, 
 * lorsque le système est plus rapide ou occupe moins de mémoire avec peu d'objets 
 * qu'avec beaucoup d'objets similaires.
 */

/* Singleton est un patron de conception de création qui garantit que l’instance 
 * d’une classe n’existe qu’en un seul exemplaire, tout en fournissant un point 
 * d’accès global à cette instance.
 * 
 * Complexité 1/3
 * Popularité 2/3
 * 
 * Beaucoup de développeurs considèrent que le singleton est un antipatron. 
 * C’est pourquoi il est de moins en moins utilisé en C#.
 */

namespace DesignPatternImplementation.Creational.Singleton
{
    public class Controller
    {
        private static Controller instance;
        static readonly object instanceLock = new object();

        private Controller() { }

        public static Controller GetModel()
        {
            lock (instanceLock)
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }
    }
}