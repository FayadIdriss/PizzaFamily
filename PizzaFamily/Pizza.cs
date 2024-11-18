using System;
namespace PizzaFamily
{
	public class Pizza
	{
		public string nom;
		public int prix;
		public bool vegetarien;
		public List<string> ingredients;

		public Pizza (string Nom, int Prix, bool Vegetarien, List<string> Ingredients)
		{
			this.nom = Nom;
			this.prix = Prix;
			this.vegetarien = Vegetarien;
			this.ingredients = Ingredients;
		}


		public void Afficher()
		{
            if(vegetarien == true)
			{
				Console.WriteLine("Pizza " + nom + "  " + prix + "" + "euro" + " " + "(V)");
				Console.WriteLine(string.Join(",", ingredients));
                Console.WriteLine("");
            }
			else
			{
                Console.WriteLine("Pizza " + nom + "  " + prix + "" + "euro");
                Console.WriteLine(string.Join(",", ingredients));
                Console.WriteLine("");
            }
        }
	}
}

