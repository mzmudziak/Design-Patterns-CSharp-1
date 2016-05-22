namespace OrderManagement
{
	internal class ItemPack
	{
		public ItemPack(Item item, uint amount)
		{
			Item = item;
			Amount = amount;
			Price = new Price(Item.Price, amount);
		}

		public Item Item { get; set; }
		public Price Price { get; set; }
		public uint Amount { get; set; }
	}
}