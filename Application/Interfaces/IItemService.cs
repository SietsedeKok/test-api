﻿using Domain;

namespace Application.Interfaces;

public interface IItemService
{
    public Task<Item> GetItem(int id);
    public Task<IEnumerable<Item>> GetItems();
}