namespace ShellExampleGestureR;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AboutPage : ContentPage {
    public AboutPage() {
        InitializeComponent();
    }
    
    async void OnButtonClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("page2");
    }
    
    void OnTapGestureRecognizerTapped(object sender, EventArgs args)
    {
        throw new NotImplementedException();
    }
}