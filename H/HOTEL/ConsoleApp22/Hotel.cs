using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Hotel
    {
        public string Name { get; set; }


        public Hotel(string name)
        {
            Name = name;
        }

        //Room[] rooms = new Room[0];
        public Room[] rooms = new Room[0];


        public void AddRoom(Room room)
        {
            Array.Resize(ref rooms, rooms.Length + 1);

            rooms[rooms.Length - 1] = room;
        }

        public void MakeReservation(int id)
        {
            foreach (var room in rooms)
            {
                if (room.Id==id)
                {
                    if (room.IsAvailable==true)
                    {
                        room.IsAvailable = false;
                        Console.WriteLine("Room is Reserved");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Romm is fool");
                        return;
                    }
                    
                }
               
            }

            Console.WriteLine($"{id} not Found");
        }
    }
}
