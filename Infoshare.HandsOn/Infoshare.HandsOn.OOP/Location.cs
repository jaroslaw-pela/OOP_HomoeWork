using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoshare.HandsOn.OOP
{
    public class Location
    {
        private double _latitude;
        private double _longitude;


        public Location(double latitude, double longitude)
        {
            _latitude = latitude;
            _longitude = longitude;
        }

        public void Locate(double _latitude, double _longitude)
        {
            if (_latitude > 0 && _longitude > 0)
            {
                Console.WriteLine("North-East");
            }
            else if (_latitude < 0 && _longitude > 0)
            {
                Console.WriteLine("South-East");
            }
            else if (_latitude > 0 && _longitude < 0)
            {
                Console.WriteLine("North-East");
            }
            else if (_latitude < 0 && _longitude < 0)
            {
                Console.WriteLine("North-East");
            }
        }


    }
}
