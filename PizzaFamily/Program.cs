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
            Pizza myPizza1 = new Pizza("Boisé", 12, false, new List<string>
            { "Crème Fraiche ", "Escalope ", "Poivron "});
            myPizza1.Afficher();

            Pizza myPizza2 = new Pizza("Végétarien", 10, true, new List<string>
            {"Sauce Tomate ", "Steak Végé ", " Falafel"});
            myPizza2.Afficher();

            Pizza myPizza3 = new Pizza("Reine", 12, false, new List<string>
            {"Sauce tomate ", "Fromage ", "Jambon ", "Chorizo ", "Dinde " });
            myPizza3.Afficher();

            Pizza myPizza4 = new Pizza("Chèvre Miel", 10, true, new List<string>
            {"Sauce crème ", "Chevre ", "Miel " });
            myPizza4.Afficher();

            Pizza myPizza5 = new Pizza("Cannibale", 14, false, new List<String>
            {"Sauce tomate ", "Steak ", "Fromage" });
            myPizza5.Afficher();
        }
    }
}
