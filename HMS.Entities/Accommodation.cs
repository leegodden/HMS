using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
	public class Accommodation
	{
		public Accommodation(
			int id,
			AccommodationPackage accommodationPackage,
			string name,
			string description)
		{
			ID = id;
			AccommodationPackage = accommodationPackage;
			Name = name;
			Description = description;

        }

		public int ID { get; set; }

		public int AccommodationPackageID { get; set; }
		public AccommodationPackage AccommodationPackage { get; set; }

		public string? Name { get; set;}
		public string Description { get; set; }

	}
}

