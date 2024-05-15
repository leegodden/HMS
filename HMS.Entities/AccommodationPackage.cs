using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
	public class AccommodationPackage
	{
		public AccommodationPackage(){}

        public AccommodationPackage(
			int id,
			int accommodationTypeID,
			string name,
			int numOfRoom,
			decimal feePerNight)
		{

			ID = id;
			AccommodationTypeID = accommodationTypeID;
			Name = name;
			NoOfRoom = numOfRoom;
			FeePerNight = feePerNight;
		}

		public int ID { get; set; }
		public int AccommodationTypeID { get; set; }
		public AccommodationType? AccommodationType { get; set; }

		public string? Name { get; set; }
		public int NoOfRoom { get; set; }
		public decimal FeePerNight { get; set; }
    }
}

