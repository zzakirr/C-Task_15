using System;
using Models;
namespace Practise_15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("room1", 20, 5);
            room.IsAvailable = true;
            Room room1 = new Room("room2", 25, 2);
            room1.IsAvailable = false;
            Hotel hotel = new Hotel();
            hotel.AddRoom(room);
            hotel.AddRoom(room1);
            
            try
            {
                hotel.MakeReservation(2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
    }
}
