using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
	public class Booking
	{
		public Booking(Accommodation accommodation, DateTime fromdate, int duration)
		{
			Accommodation = accommodation;
			FromDate = fromdate;
			Duration = duration;
		}

		public int ID { get; set; }
		public Accommodation Accommodation { get; set; }
		public DateTime FromDate { get; set; }

		public int Duration { get; set; }

	}
}

