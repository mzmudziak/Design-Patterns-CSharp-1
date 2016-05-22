namespace OrderManagement
{
	internal class Customer
	{
		public Customer(string name, string surname, Country country)
		{
			Name = name;
			Surname = surname;
			Country = country;
		}

		public string Name { get; set; }

		public string Surname { get; set; }

		public Country Country { get; set; }
	}
}