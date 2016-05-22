using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
	class FileReader
	{
		public static List<string> Read(string filename)
		{

			StreamReader sr = new StreamReader(filename);
			string line;
			List<String> s  = new List<string>();
			while ((line = sr.ReadLine()) != null)
			{
			s.Add(line);
	
			}
			return s;
		}

	}
}
