using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace App;

public partial class GrafickNormaWindow : Window
{
    public GrafickNormaWindow()
    {
        InitializeComponent();
    }
    
    private void ExitButton_Click(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
    }


}