using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Room
    {
        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            
            ++_id;
            Id = _id;
            IsAvialable=true;
        }

        static int _id { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvialable { get; set; }

        public string ShowInfo()
        {
            return $"Room ID: {Id}, Room name: {Name},  Room price: {Price}, Capacity: {PersonCapacity}, IsAvailable: {IsAvialable}";
        }

        public override string ToString()
        {
            return ShowInfo();
        }


    }
}
