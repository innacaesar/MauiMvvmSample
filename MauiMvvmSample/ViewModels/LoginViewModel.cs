using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMvvmSample.Repositories.Interfaces;
using MauiMvvmSample.Services;

namespace MauiMvvmSample.ViewModels;

public partial class LoginViewModel : ObservableObject
{
   // private readonly IUserRepository _userRepository;
    private readonly IAuthService _authService; // Inject the IAuthService dependency

    private readonly IUserSession _userSession; // Inject the IUserSession dependency
    public LoginViewModel( // Constructor that takes IAuthService and IUserSession as parameters
    IAuthService authService,
    IUserSession userSession)
    {
        _authService = authService;
        _userSession = userSession;
    }


    [ObservableProperty]
    private string email = string.Empty;

    [ObservableProperty]
    private string password = string.Empty;

    //public LoginViewModel(IUserRepository userRepository)
    //{
    //    _userRepository = userRepository;
    //}



    //  [RelayCommand]

    //private async Task LoginAsync()
    //{
    //    try
    //    {
    //        var user = await _authService.LoginAsync(
    //            Email,
    //            Password);

    //        if (user == null)
    //        {
    //            await Shell.Current.DisplayAlert(
    //                "Login",
    //                "Invalid email or password.",
    //                "OK");

    //            return;
    //        }

    //        await Shell.Current.GoToAsync(
    //            "home",
    //            new Dictionary<string, object>
    //            {
    //            { "user", user }
    //            });
    //    }
    //    catch (Exception ex)
    //    {
    //        await Shell.Current.DisplayAlert(
    //            "Error",
    //            ex.Message,
    //            "OK");
    //    }
    //}


    //[RelayCommand]
    //private async Task LoginAsync()
    //{
    //    try
    //    {
    //        var user = await _authService.LoginAsync(
    //            Email,
    //            Password);

    //        if (user == null)
    //        {
    //            await Shell.Current.DisplayAlert(
    //                "Login",
    //                "Invalid email or password.",
    //                "OK");

    //            return;
    //        }
    //        //מעבר את המשתמש לדף הבית עם פרטי המשתמש
    //        await Shell.Current.GoToAsync(
    //            "home",
    //            new Dictionary<string, object>
    //            {
    //            { "user", user }
    //            });


    //        // התחברות הצליחה — מציגים את תפריט הניווט
    //        if (Shell.Current is AppShell appShell)
    //        {
    //            appShell.ShowMainMenu();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        await Shell.Current.DisplayAlert(
    //            "Error",
    //            ex.Message,
    //            "OK");
    //    }
    //}


    [RelayCommand]
    private async Task LoginAsync()
    {
        try
        {
            var user = await _authService.LoginAsync(
                Email,
                Password);

            if (user == null)
            {
                await Shell.Current.DisplayAlert(
                    "Login",
                    "Invalid email or password.",
                    "OK");

                return;
            }

            // שמירת המשתמש המחובר
            _userSession.CurrentUser = user;

            // הצגת התפריט ומעבר ל-Home
            if (Shell.Current is AppShell appShell)
            {
                appShell.ShowMainMenu();
            }
        }
        catch (Exception ex)
        {
            await Shell.Current.DisplayAlert(
                "Error",
                ex.Message,
                "OK");
        }
    }

    [RelayCommand]
    private async Task GoToRegisterAsync()
    {
        await Shell.Current.GoToAsync("register");
    }


}

