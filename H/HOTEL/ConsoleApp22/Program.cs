using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Room room1 = new Room("1ci",21.90,2);
            Room room2 = new Room("2ci", 27.90, 2);
            Room room3 = new Room("3ci", 28.90, 3);
            Hotel hotel = new Hotel("BAku");

            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);

            hotel.MakeReservation(1);
            hotel.MakeReservation(2);
            hotel.MakeReservation(2);







        }
    }
}
