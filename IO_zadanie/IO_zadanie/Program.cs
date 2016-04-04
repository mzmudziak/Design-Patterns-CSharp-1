using System;

namespace IO_zadanie
{
	class Program
	{
		public static void Main(string[] args)
		{
			Customers customers = new Customers();
			Currency pln = new Currency(1, "PLN");
			Currency gbp = new Currency(6, "GBP");
			Country polska = new Country(20, "Poland", "PL", pln);
 		Country anglia = new Country(40, "Great Britain", "GB", gbp);
			customers.Add(new Customer("Piotr", "Omiotek", polska));
  	customers.Add(new Customer("Marcin", "Tokar", polska));
			customers.Add(new Customer("John", "Smith", anglia));
			Orders orders = new Orders();
			customers.ShowList();
			Console.WriteLine();
			DataParser.Work("test.txt", customers, orders);
					
			orders.List();
															orders.Pay();
		}
	}
}

/*
Tokar Marcin 1 20 stolik 125
Tokar Marcin 1 3 szafa 500
Tokar Marcin 2 7 lustro 100
Tokar Marcin 2 3 szafa 450
Tokar Marcin 3 7 szafa 400
Smith John 4 15 lustro 120
Smith John 4 1 szafa 800
Smith John 5 1 lustro 80
Smith John 5 1 szafa 600
Smith John 5 2 lustro 90 (tak, drugi raz lustro w zamówieniu w innej cenie)
Omiotek Piotr 6 123 lustro 50
Omiotek Piotr 6 1 szafa 540
Omiotek Piotr 6 1 lustro 100
 
				*/
