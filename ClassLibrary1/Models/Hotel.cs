using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Hotel
    {
        public Hotel(string name)
        {
            Name = name;
            ++_id;
            Id=_id;
        }
        static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public string ShowAllHotels()
        {
            return $"Hotel name: {Name}, Hotel ID:{Id}";
        }

        public override string ToString()
        {
            return ShowAllHotels();
        }

        
    }
}
