namespace MauiApp2.View;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}
<<<<<<< HEAD
	
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
=======
>>>>>>> 8d431b68e110012532460a3aa9a2b6632287557f
}