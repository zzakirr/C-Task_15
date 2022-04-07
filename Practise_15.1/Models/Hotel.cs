using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms = new Room[0];
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public void MakeReservation(int? roomId)
        {
            
           if(roomId != null)
           {
                foreach (var item in _rooms)
                {
                    if (item.ID == roomId)
                    {
                        if (item.IsAvailable)
                        {
                            item.ShowInfo();
                        }
                        else
                            throw new NotAvailableException("Otaq reserv olunub");
                    }
                }

            }
           else
            {
                throw new NotAvailableException("Xeta bas verdi:roomId Null-di");
            }
        }
           
                
           
        
    }
}
