/* Le monteur (builder) est un patron de conception utilisé pour la 
 * création d'une variété d'objets complexes à partir d'un objet source. 
 * L'objet source peut consister en une variété de parties contribuant 
 * individuellement à la création de chaque objet complet grâce à un 
 * ensemble d'appels à l'interface commune de la classe abstraite Monteur.
 */

/* Monteur est un patron de conception de création qui permet de 
 * construire des objets complexes étape par étape. Il permet de 
 * produire différentes variations ou représentations d’un objet 
 * en utilisant le même code de construction.
 * 
 * Complexité 2/3
 * Popularité 3/3
 * 
 * Le monteur est bien connu dans le monde du C#. Il se montre très 
 * utile lorsque vous devez créer un objet possédant de nombreuses 
 * configurations possibles.
 */

namespace DesignPatternImplementation.Creational.Builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public string Garnish { get; set; }
    }

    public abstract class PizzaBuilder
    {
        public Pizza Pizza { get; set; }

        public abstract void BuildDough();
        public abstract void BuildSauce();
        public abstract void BuildGarnish();
    }

    public class ReinePizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.Dough = "Reine Dough";
        }
        public override void BuildSauce()
        {
            Pizza.Sauce = "Reine Sauce";
        }
        public override void BuildGarnish()
        {
            Pizza.Dough = "Reine Garnish";
        }
    }

    public class MargaritaPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            Pizza.Dough = "Margarita Dough";
        }
        public override void BuildSauce()
        {
            Pizza.Sauce = "Margarita Sauce";
        }
        public override void BuildGarnish()
        {
            Pizza.Dough = "Margarita Garnish";
        }
    }

    public class Serveur
    {
        public PizzaBuilder PizzaBuilder { get; set; }

        public Pizza GetPizza()
        {
            return PizzaBuilder.Pizza;
        }
        public void BuildPizza()
        {
            PizzaBuilder.Pizza = new Pizza();
            PizzaBuilder.BuildDough();
            PizzaBuilder.BuildSauce();
            PizzaBuilder.BuildGarnish();
        }
    }
}
