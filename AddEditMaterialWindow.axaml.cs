using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup;
using Avalonia.Interactivity;

namespace App;

public partial class AddEditMaterialWindow : Window
{
    public AddEditMaterialWindow()
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