﻿using Fiorello_MVC.Models;

namespace Fiorello_MVC.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int? id);
    }
}
