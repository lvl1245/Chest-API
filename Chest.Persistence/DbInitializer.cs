
namespace Chest.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ChestDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
