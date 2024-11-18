using System;
namespace PizzaFamily
{
	public class Pizza
	{
		public string nom;
		public int prix;
		public bool vegetarien;

		public Pizza (string Nom, int Prix, bool Vegetarien)
		{
			this.nom = Nom;
			this.prix = Prix;
			this.vegetarien = Vegetarien;
		}


		public void Afficher()
		{
            if(vegetarien == true)
			{
				Console.WriteLine("Pizza " + nom + "  " + prix + "" + "euro" + " " + "(V)");
			}
			else
			{
                Console.WriteLine("Pizza " + nom + "  " + prix + "" + "euro");
            }
        }
	}
}

