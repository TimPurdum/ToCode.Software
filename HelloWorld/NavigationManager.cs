using System.Drawing;

namespace HelloWorld
{
    public static class NavigationManager
    {
        public static Room MoveEast(Room startingRoom)
        {
            var point = new Point(startingRoom.Position.X + 1, startingRoom.Position.Y);
            return FindRoomAtPoint(point);
        }

        public static Room MoveWest(Room startingRoom)
        {
            var point = new Point(startingRoom.Position.X - 1, startingRoom.Position.Y);
            return FindRoomAtPoint(point);
        }

        public static Room MoveNorth(Room startingRoom)
        {
            var point = new Point(startingRoom.Position.X, startingRoom.Position.Y + 1);
            return FindRoomAtPoint(point);
        }

        public static Room MoveSouth(Room startingRoom)
        {
            var point = new Point(startingRoom.Position.X, startingRoom.Position.Y - 1);
            return FindRoomAtPoint(point);
        }

        private static Room FindRoomAtPoint(Point point)
        {
            foreach (var room in Rooms.AllRooms)
            {
                if (room.Position == point)
                {
                    return room;
                }
            }

            return null;
        }
    }
}