using MauiMvvmSample.Models;

namespace MauiMvvmSample.Repositories.Interfaces;

public interface IUserRepository
{
    Task AddAsync(User user); //async method to add a user
    Task<User?> GetByIdAsync(string id); //async method to get a user by id
    Task UpdateAsync(User user); //async method to update a user
}

