using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace App;

public partial class AddEditZayavkaWindow : Window
{
    public AddEditZayavkaWindow()
    {
        InitializeComponent();
    }

    private void EndButton_Click(object? sender, RoutedEventArgs e)
    {
    if (sender is Button button)
    {
        button.Content = "✓ Заявка отправлена";
        button.IsEnabled = false;
    }
    }
}