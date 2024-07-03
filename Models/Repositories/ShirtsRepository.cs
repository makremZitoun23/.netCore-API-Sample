namespace WebApplication1.Models.Repositories
{
    public static class ShirtsRepository
    {
        public static List<Shirt> shirts = new List<Shirt>()
        {

            new Shirt {ShirtId = 1 , Brand ="My Brand", Color ="Blue", Gender="Men", Size= 30 , Price= 10},
            new Shirt {ShirtId = 2 , Brand ="My Brand", Color ="Black", Gender="Men", Size= 35, Price= 12},
            new Shirt {ShirtId = 3 , Brand ="Your Brand", Color ="Pink", Gender="Women", Size= 28 , Price=8},
            new Shirt {ShirtId = 4 , Brand ="Your Brand", Color ="Yello", Gender="Women", Size= 30, Price=9}
        };

        public static bool ShirtsExists(int id)
        {
            return shirts.Any(x=>x.ShirtId == id);
        }

        public static Shirt? GetShirtById(int id)
        { return shirts.FirstOrDefault(x => x.ShirtId == id); }
    }
}
