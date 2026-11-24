using Avalonia.Controls;
using Avalonia.Interactivity;

namespace App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OtchetButton_Click(object? sender, RoutedEventArgs e)
    {
        new OtchetWindow().Show();
    }

    private void MaterialButton_Click(object? sender, RoutedEventArgs e)
    {
        new MaterialWindow().Show();
    }
    private void ZaivkaSotrudnikButton_Click(object? sender, RoutedEventArgs e)
    {
        new ZaivkaSotrudnikWindow().Show();
    }
    private void GrafickNormaButton_Click(object? sender, RoutedEventArgs e)
    {
        new GrafickNormaWindow().Show();
    }

    private void OborudovanieDataGrid_LoadingRow(object? sender, DataGridRowEventArgs e)
    {
        if (e.Row.DataContext is Oborudovanie oborudovanie)
        e.Row.Classes.Set("needs-service", oborudovanie.NeedsService);
    }
    private void ExitButton_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}