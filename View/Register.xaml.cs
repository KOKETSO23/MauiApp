namespace MauiApp2.View;

public partial class Register : ContentPage
{
	public Register()
	{
        InitializeComponent();
    }

    private async void Back2login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new LoginView());
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        ConfirmPsd.IsPassword = !e.Value;
        Password.IsPassword = !e.Value;
    }
}