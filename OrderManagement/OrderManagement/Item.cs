namespace OrderManagement
{
	internal class Item
	{
		public Item(string name, Price price)
		{
			Name = name;
			Price = price;
		}

		public string Name { get; set; }
		public Price Price { get; set; }
	}
}