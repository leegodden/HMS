using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccommodationType
    {
        // Default constructor
        public AccommodationType() { }

        // Parameterized constructor for initializing the properties
        public AccommodationType(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }


    }
}