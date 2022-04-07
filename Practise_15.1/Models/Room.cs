using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Room
    {
        private static int _id = 0;
        public Room(string name,double price,int personCapacity)
        {
            this.Name = name;
            this.Price = price;
            this.PersonCapasity = personCapacity;
            _id++;
            this.ID = _id;
            
        }
        public int ID;
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapasity { get; set; }
        public bool IsAvailable { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id:{this.ID}-Name:{this.Name}-Price:{this.Price}-PersonCapacity:{this.PersonCapasity}" +
                $"-IsAvailable:{this.IsAvailable}");
        }

    }
}
