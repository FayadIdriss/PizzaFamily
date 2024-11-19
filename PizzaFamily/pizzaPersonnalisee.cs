using System;

namespace PizzaFamily
{
    public class PizzaPersonnalisee : Pizza
    {
        public PizzaPersonnalisee() : base("Personnalisé", 10, false, new List<string>())
        {
            ingredients = new List<string>();

            Console.WriteLine("Veuillez saisir les ingrédients souhaités (tapez Entrée pour terminer) :");
            while (true)
            {
                var ingredient = Console.ReadLine();

                // Si l'utilisateur tape une chaîne vide ou null, on arrête la boucle
                if (string.IsNullOrWhiteSpace(ingredient))
                {
                    break;
                }

                ingredients.Add(ingredient);
            }
        }
    }
}

 