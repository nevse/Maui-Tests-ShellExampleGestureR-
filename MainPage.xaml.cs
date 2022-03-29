namespace ShellExampleGestureR;

public partial class MainPage : Shell
{
	
	public MainPage()
	{
		InitializeComponent();
		Routing.RegisterRoute("page2", typeof(AboutPage2));
	}

	
}

