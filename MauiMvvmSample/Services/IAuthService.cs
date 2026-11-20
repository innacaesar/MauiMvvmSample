using MauiMvvmSample.Models;

namespace MauiMvvmSample.Services;

public interface IAuthService
{
    Task RegisterAsync(  //async method to register a user
        string username,
        string email,
        string phone,
        string password);

    Task<User?> LoginAsync( //async method to login a user
        string email,
        string password
        
        );
}
