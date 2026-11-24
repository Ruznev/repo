using Avalonia.Controls;
using Avalonia.Interactivity;

namespace App;

public partial class AuthorizationWindow : Window
{
    public AuthorizationWindow()
    {
        InitializeComponent();
    }

    private void Author_Click(object? sender, RoutedEventArgs e)
    {
        string login = EmailBox.Text ?? string.Empty;         
        string password = PasswordBox.Text ?? string.Empty;
    }

    private void Reg_Click(object? sender, RoutedEventArgs e)
    {
        var win = new RegistrationWindow();
          win.Show();
        this.Close();
    }
    
}