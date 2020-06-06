using System.Drawing;

namespace HelloWorld
{
    public static class Rooms
    {
        public static Room FirstRoom { get; set; } = new Room()
        {
            WelcomeMessage = "You wake up in a strange room.",
            Position = new Point(0, 0),
        };

        public static Room FrontYard { get; set; } = new Room()
        {
            WelcomeMessage = "You exit the house into the front yard. The sun is shining, the birds are singing. You are free!",
            Position = new Point(-1, -1),
        };

        public static Room CreepyAttic  {get; set; } = new Room()
        { WelcomeMessage =  "You climb up into a deserted attic where the giant spider eggs live.",
            Position = new Point(1, 1),
        };
 public static Room CreepyBasement  {get; set; } = new Room()
        { WelcomeMessage = "You crash into a weird basement.",
            Position = new Point(0, 1)
        };
        public static Room Kitchen {get; set; } = new Room()
        {
            WelcomeMessage = "You find yourself in an old kitchen, which appears to not have been used for many years.",
            Position = new Point(0, -1),
        };
        public static Room Library {get; set; } = new Room()
        {
            WelcomeMessage = "You enter a large area with rows of shelves full of hundreds of books.",
            Position = new Point(0, -2),
        };

        public static Room Closet {get; set; } = new Room()
        {
             WelcomeMessage = "You walk into a small, dark room. It appears to be some sort of closet.",
            Position = new Point(1, 0),
        };
public static Room Bathroom {get; set; } = new Room()
        {
             WelcomeMessage = "You enter a brightly lit bathroom. The floor is a dirty white tile that matches the walls, and there is a cracked bathtub, a sink, and a rusty toilet.",
            Position = new Point(1, -1),
        };

        public static Room[] AllRooms = new Room[]
        {
            FirstRoom,
            CreepyBasement,
            Closet,
            Kitchen,
            Bathroom,
            FrontYard, 
            CreepyAttic,
            Library
        };
    }
}