using Domain;

namespace Infrastructure.Interfaces;

public interface IItemRepository
{
    Task<IEnumerable<Item>> GetItemsFromDb();
    Task<Item> GetItemFromDb(int id);
}