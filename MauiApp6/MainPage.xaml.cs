namespace MauiApp6;

public partial class MainPage : ContentPage
{
    private readonly AddViewModel addViewModel;

    public MainPage(AddViewModel addView)
    {
        addViewModel = addView;
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        AddPage addPage = new(addViewModel);
        await Navigation.PushAsync(addPage);
    }
}

