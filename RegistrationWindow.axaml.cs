using Avalonia.Controls;
using Avalonia.Interactivity;

namespace App;

public partial class RegistrationWindow : Window
{
    public RegistrationWindow()
    {
        InitializeComponent();
    }

private void Register_Click(object? sender, RoutedEventArgs e)
{
    var win = new AuthorizationWindow();
        win.Show();
    this.Close();
}
}