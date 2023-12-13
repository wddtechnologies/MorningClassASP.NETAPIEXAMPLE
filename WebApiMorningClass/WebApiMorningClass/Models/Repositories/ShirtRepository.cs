namespace WebApiMorningClass.Models.Repositories
{
    public class ShirtRepository
    {
        private static List<Shirt> shirts = new List<Shirt>()
        {
        new Shirt{ Id = 1, Brand ="My Brand", Color = "Blue", Gender="Men", Price = 30, Size = 10},
        new Shirt{ Id = 2, Brand ="My Brand", Color = "Grenn",Gender="Men", Price = 30, Size = 12},
        new Shirt{ Id = 3, Brand ="My Brand", Color = "Red", Gender="Women", Price = 30, Size = 6}
        };

        public static bool ShirtExists(int id)
        {
            return shirts.Any(x => x.Id == id);
        }
        public static Shirt? GetShirtById(int id)
        {
            return shirts.FirstOrDefault(x => x.Id == id);
        }
    }
}
