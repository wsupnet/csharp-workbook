using System;

namespace _03Week
{

    public class Land 
    {
        public int house {get;set;}
        public string activity {get;set;}
    }

    public class House 
    {
        public int rooms {get;set;}
        public int floors {get;set;}
    }

    public class Room 
    {
        public string color {get;set;}

        public string floorType {get;set;}

        public int window {get;set;}
    }
}