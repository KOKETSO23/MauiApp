namespace MauiApp2.View;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}
	
    private void Signin_Clicked(object sender, EventArgs e)
    {
        {
            Navigation.PushModalAsync(new Register());
        }

    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Password.IsPassword = !e.Value;
    }
}