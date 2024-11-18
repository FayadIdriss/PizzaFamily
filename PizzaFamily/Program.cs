using System;

namespace PizzaFamily
{
    /// <summary>
    /// Ceci est une implémentation du message traditionnel « Hello world! »
    /// </summary>
    public class PizzaFamily
    {
        /// <summary>
        /// Le programme commence ici
        /// </summary>
        public static void Main(string[] args)
        {
            Pizza myPizza1 = new Pizza("Boisé", 12, false);
            myPizza1.Afficher();

            Pizza myPizza2 = new Pizza("Végétarien", 10, true);
            myPizza2.Afficher();
        }
    }
}
