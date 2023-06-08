using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryAxisCustomization_CartesianChart_MAUI
{
	public class ViewModel
	{
		public List<Model> Data { get; set; }
		public List<Model> Data1 { get; set; }
		public List<Model> Data2 { get; set; }

		public ViewModel()
		{

			Data = new List<Model>()
			{
				new Model(){Category = "Tech", Sales = 500},
				new Model(){Category = "Clothing", Sales = 350},
				new Model(){Category = "Decor", Sales = 400},
				new Model(){Category = "Beauty", Sales = 250},
				new Model(){Category = "Sports", Sales = 300},
				new Model(){Category = "Books", Sales = 200},
				new Model(){Category = "Toys", Sales = 450},
				new Model(){Category = "Jewelry", Sales = 150},
				new Model(){Category = "Health", Sales = 350},
			};

			Data1 = new List<Model>()
			{
				new Model(){Year = 2005, Sales = 320},
				new Model(){Year = 2006, Sales = 450},
				new Model(){Year = 2007, Sales = 500},
				new Model(){Year = 2008, Sales = 420},
			};

			Data2 = new List<Model>()
			{
				new Model(){Year = 2015, Sales = 550},
				new Model(){Year = 2016, Sales = 480},
				new Model(){Year = 2017, Sales = 520},
				new Model(){Year = 2018, Sales = 450},
			};

		}
	}
}
