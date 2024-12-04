namespace StylesDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Application
			.Current!
			.Resources
			.TryGetValue("specialButton", out var specialStyle);

		Resources["dynamicResource"] = specialStyle;

    }

    
}



