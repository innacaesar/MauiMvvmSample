using MauiMvvmSample.ViewModels;

namespace MauiMvvmSample.Views;

public partial class Page1 : ContentPage
{
	public Page1(HomeViewModel vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}