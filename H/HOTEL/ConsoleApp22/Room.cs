using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22
{
    class Room
    {
        public bool IsAvailable { get; set; }
        public string Name { get; set; }
        private double _price;

        private byte _personcapacity;

        public static int id;

        public int Id { get; protected set; }

        public double Price { 
            get
            {
                return _price;
            }
            set
            {
                if (value>0)
                {
                    _price = value;
                }
            } 
        }

        public byte PersonCapacity { 
            get
            {
                return _personcapacity;
            }
            set
            {
                if (value>0 && value<25)
                {
                    _personcapacity = value;
                }
            } 
        }



       


        public Room(string name,double price,byte personcapacity)
        {
            IsAvailable = true;
            Id = ++id;
            Name = name;
            Price = price;
            PersonCapacity = personcapacity;

        }


        public string ShowInfo()
        {
            return $"Id:{Id},Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}, {(IsAvailable ? "Rezerv Olunmayib" : "Rezerv Olunub")}";

        }

        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
