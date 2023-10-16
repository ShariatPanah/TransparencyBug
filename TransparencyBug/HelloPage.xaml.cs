namespace TransparencyBug;

public partial class HelloPage : ContentPage
{
	public HelloPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}