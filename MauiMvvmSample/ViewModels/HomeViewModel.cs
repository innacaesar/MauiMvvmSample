using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmSample.Models;
using MauiMvvmSample.Services;

namespace MauiMvvmSample.ViewModels;

//[QueryProperty(nameof(User), "user")] //קישור בין המשתנה User לבין הפרמטר "user" שנשלח מהדף הקודם
public partial class HomeViewModel : ObservableObject
{
    private readonly IAuthService _authService;// Inject the IAuthService dependency
    private readonly IUserSession _userSession;// Inject the IUserSession dependency

    
    public User? CurrentUser => _userSession.CurrentUser;

    public HomeViewModel(IAuthService authService, IUserSession userSession)
    {
        _authService = authService;
        _userSession = userSession;

       
    }

    








    //[RelayCommand]
    //private async Task EditEmailAsync()
    //{
    //    var newEmail = await Shell.Current.DisplayPromptAsync(
    //        "Edit Email",
    //        "Enter new email:",
    //        initialValue: User.Email);

    //    if (string.IsNullOrWhiteSpace(newEmail))
    //        return;

    //    //await _authService.UpdateProfileAsync(
    //    //    User,
    //    //    newEmail,
    //    //    User.Phone);

    //    OnPropertyChanged(nameof(User));
    //}

    //[RelayCommand]
    //private async Task EditPhoneAsync()
    //{
    //    var newPhone = await Shell.Current.DisplayPromptAsync(
    //        "Edit Phone",
    //        "Enter new phone:",
    //        initialValue: User.Phone);

    //    if (string.IsNullOrWhiteSpace(newPhone))
    //        return;

    //    //await _authService.UpdateProfileAsync(
    //    //    User,
    //    //    User.Email,
    //    //    newPhone);

    //    OnPropertyChanged(nameof(User));
    //}
}
