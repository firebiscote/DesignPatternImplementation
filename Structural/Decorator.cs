/* Un décorateur permet d'attacher dynamiquement de nouveaux 
 * comportements ou responsabilités à un objet. Les décorateurs 
 * offrent une alternative assez souple à l'héritage pour composer 
 * de nouvelles fonctionnalités.
 */

/* Décorateur est un patron de conception structurel qui permet 
 * d’affecter dynamiquement de nouveaux comportements à des objets 
 * en les plaçant dans des emballeurs qui implémentent ces comportements.
 * 
 * Complexité 2/3
 * Popularité 2/3
 * 
 * Le décorateur est assez standard en C#, surtout dans le code qui 
 * utilise les flux (stream).
 */

namespace DesignPatternImplementation.Structural.Decorator
{
    public interface ICar
    {
        public double Price { get; }
    }

    public class AstonMartin : ICar
    {
        double ICar.Price { get { return 999.99; } }
    }

    public class Option : ICar
    {
        protected ICar original;
        protected double optionPrice;

        public Option(ICar original, double optionPrice)
        {
            this.original = original;
            this.optionPrice = optionPrice;
        }

        double ICar.Price { get { return original.Price + optionPrice; } }
    }

    public class AirConditioner : Option
    {
        public AirConditioner(ICar original) : base(original, 1.0) { }
    }

    public class Parachute : Option
    {
        public Parachute (ICar original) : base(original, 10.0) { }
    }
}
