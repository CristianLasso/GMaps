using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    class Airport
    {

        private String city;
        private int airportID;

        public Airport(String c, int id) {
            city = c;
            airportID = id;
        }

        public String City { get; set; }
        public String AirportID { get; set; }

        
    }
}
