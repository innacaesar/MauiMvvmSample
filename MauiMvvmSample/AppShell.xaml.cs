
namespace MauiMvvmSample;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // נתיב לעמוד ההרשמה
        Routing.RegisterRoute(
            "register",
            typeof(Views.RegisterPage));

        Routing.RegisterRoute(
            "home",
            typeof(Views.HomePage));
    }
    

    

    public void ShowMainMenu()
    {
        Shell.SetFlyoutItemIsVisible(HomeItem, true);
        Shell.SetFlyoutItemIsVisible(Page1Item, true);
        Shell.SetFlyoutItemIsVisible(Page2Item, false);// Hide Page2Item
        Shell.SetFlyoutItemIsVisible(CloseItem, true);

        FlyoutBehavior = FlyoutBehavior.Flyout;
        CurrentItem = HomeItem;
    }

    private void OnCloseClicked(object sender, EventArgs e)
    {
        Application.Current?.Quit();
    }
}