using System;

namespace PizzaFamily
{
    /// <summary>
    /// Ceci est une implémentation du message traditionnel
    /// </summary>
    public class PizzaFamily
    {
        /// <summary>
        /// Le programme commence ici
        /// </summary>
        public static void Main(string[] args)
        {
            // Les des Pizza à afficher par défault
            var pizzas = new List<Pizza>()
            {
                new PizzaPersonnalisee(),
                new Pizza("Carnivore", 14, false, new List<string> {"Sauce tomate, Fromage, Steak, jambon"}),
                new Pizza("3 fromages", 8, true, new List<string> {"Sauce tomate, Fromage de chevre, Gouda, Fromage blue"}),
                new Pizza("Boisée", 12, false, new List<string> {"Sauce fromagère, Fromage, Escalope, Poivron"}),
                new Pizza("Végé", 11, true, new List<string>{"Sauce verte, Fromage, Steack Végie, Falafels"}),
                new Pizza("Reine", 12, false, new List<string>{"Sauce tomate, Fromage, Jambon, Chorizo, Escalope de dinde"})
            };


            // Tri des produits par prix du plus grand au plus petit
            var pizzaTries = pizzas.OrderBy(p => p.prix).ToList();

            // Affichage des produits triés
            foreach (var pizza in pizzaTries)
            {
                pizza.Afficher();
            }
        }
    }
}
