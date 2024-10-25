namespace MauiApp6;

public partial class AddPage : ContentPage
{
    private readonly AddViewModel ViewModel;

    public AddPage(AddViewModel vm)
    {
        BindingContext = ViewModel = vm;
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        ViewModel.SetIcon();
    }
}

