using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows;
using System.IO;

namespace IO_zadanie
{
					class FileReader
					{
										public static List<string> read(string source)
										{
															/*
															@param source source filename
															*/
															List<string> strings = new List<string>();
															String line;
															try
															{
																				StreamReader sr = new StreamReader(source);
																				while ((line = sr.ReadLine()) != null)
																				{
																									strings.Add(line);
																				}
																				sr.Close();
																			

															}
															catch (IOException e)
															{
																				Console.WriteLine("File couldn't be open");
																				Console.WriteLine(e.Message);
															}
															return strings;

										}
					}

					class Currency
					{


					}

					class Price
					{

					}

					class Item
					{

					}

					class ItemPack
					{

					}

					class Order
					{

					}

					class Customer
					{

					}

					class CustomersAggregate
					{

					}

					class OrdersAggregate
					{

					}

					class Program
					{
										static void Main(string[] args)
										{
										}
					}
}
