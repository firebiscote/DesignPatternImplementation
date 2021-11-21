/*Le patron de conception façade a pour but de cacher une conception 
 * et une interface ou un ensemble d'interfaces complexes difficiles 
 * à comprendre (cette complexité étant apparue "naturellement" avec 
 * l'évolution du sous-système en question). La façade permet de simplifier 
 * cette complexité en fournissant une interface simple du sous-système. 
 * Habituellement, la façade est réalisée en réduisant les fonctionnalités 
 * de ce dernier mais en fournissant toutes les fonctions nécessaires 
 * à la plupart des utilisateurs.
 * */

using System;

namespace DesignPatternImplementation.Structural
{
    public class UserFriendlyName
    {
        private FirstName firstName;
        private LastName lastName;

        public UserFriendlyName(string name)
        {
            string[] splitName = name.Split(" ");
            firstName = new FirstName(splitName[0]);
            lastName = new LastName(splitName[1]);
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public void WriteName()
        {
            Console.WriteLine(GetName());
        }
    }

    public class FirstName
    {
        private string firstName;

        public FirstName(string firstName)
        {
            this.firstName = firstName;
        }
    }

    public class LastName
    {
        private string lastName;

        public LastName(string lastName)
        {
            this.lastName = lastName;
        }
    }
}
