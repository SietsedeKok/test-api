namespace Domain;

public class Item
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    
    public Item(int id, string name) {
        Id = id;
        Name = name;
    }
}

