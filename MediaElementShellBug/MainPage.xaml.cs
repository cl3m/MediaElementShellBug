namespace MediaElementShellBug;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Browser.Default.OpenAsync(new Uri("https://www.microsoft.com"), BrowserLaunchMode.SystemPreferred);
    }
}


