
using MauiMvvmSample.Models;


namespace MauiMvvmSample.Services;

public interface IUserSession
{
    User? CurrentUser { get; set; }
}