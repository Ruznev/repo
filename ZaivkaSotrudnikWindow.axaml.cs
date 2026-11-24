using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace App;

public partial class ZaivkaSotrudnikWindow : Window
{
    public ZaivkaSotrudnikWindow()
    {
        InitializeComponent();
    }

    private void ZayavkaDataGrid_LoadingRow(object? sender, DataGridRowEventArgs e)
    {
        if (e.Row.DataContext is Zaiavka zaiavka)
        e.Row.Classes.Set("needs-status", zaiavka.NeedsStatus);
        if (e.Row.DataContext is Zaiavka zayavka)
        e.Row.Classes.Set("needs-priority", zayavka.NeedsPriority);
    }
    
    private void ExitButton_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void RefreshButton_Click(object sender, RoutedEventArgs e)
    {
        //LoadMaterials();
    }

    private void AddZayavkaButton_Click(object sender, RoutedEventArgs e)
    {
        var win = new AddEditZayavkaWindow();
        win.Show();
        //LoadMaterials();
    }

    private void EditZayavkaButton_Click(object sender, RoutedEventArgs e)
    {
        //if (MaterialsDataGrid.SelectedItem is MaterialDisplayDto item)
        //{
        //    var win = new AddEditMaterialWindow(item.Id);
        //    win.ShowDialog();
        //    LoadMaterials();
        //}
        //else
        //{
        //    MessageBox.Show("Выберите материал для редактирования.");
        //}
    }
}