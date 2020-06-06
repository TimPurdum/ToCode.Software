using System;
using System.Threading;

namespace HelloWorld
{
    public class Game
    {
        public void Start()
        {
            _currentRoom = Rooms.FirstRoom;
            while (true)
            {
                GetData();
            }
        }


        public void GetData()
        {
            // a question or statement
            Console.WriteLine(_currentRoom.WelcomeMessage);
            Console.WriteLine("Where do you want to go? (Enter north, south, east or west)");

            // user gives input
            var response = Console.ReadLine();

            Room newRoom = null;
            switch (response.ToString().ToLower())
            {
                case "east":
                    newRoom = NavigationManager.MoveEast(_currentRoom);
                    break;
                case "west":
                    newRoom = NavigationManager.MoveWest(_currentRoom);
                    break;
                case "north":
                    newRoom = NavigationManager.MoveNorth(_currentRoom);
                    break;
                case "south":
                    newRoom = NavigationManager.MoveSouth(_currentRoom);
                    break;
                default:
                    Console.WriteLine("I don't understand");
                    break;
            }

            if (newRoom == null)
            {
                Console.WriteLine("There's no door in that direction.");
            }
            else
            {
                _currentRoom = newRoom;
            }

            Thread.Sleep(1000);
        }

        private Room _currentRoom;
    }
}
