using Domain;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class ItemRepository : IItemRepository
{

    private readonly List<Item> _items = new List<Item>
    {
        new(1, "item 1")
        {
            Id = 1,
            Name = "item 10"
        },
        new(2, "item 2")
        {
            Id = 2,
            Name = "item 2"
        }
    };
    
    public async Task<IEnumerable<Item>> GetItemsFromDb()
    {
        return await Task.FromResult<IEnumerable<Item>>(_items);
    }

    public async Task<Item> GetItemFromDb(int id)
    {
        var item = _items
            .First(i => i.Id == id);
        return await Task.FromResult(item);
    }
}