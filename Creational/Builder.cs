using System;
using System.Collections.Generic;
using System.Text;

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
