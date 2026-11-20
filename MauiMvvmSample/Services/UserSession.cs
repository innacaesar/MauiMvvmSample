
using MauiMvvmSample.Models;

namespace MauiMvvmSample.Services;

public  class UserSession : IUserSession
{
    public User? CurrentUser { get; set; }
}