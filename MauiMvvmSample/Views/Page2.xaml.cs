using MauiMvvmSample.ViewModels;

namespace MauiMvvmSample.Views;

public partial class Page2 : ContentPage
{
	public Page2(HomeViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}