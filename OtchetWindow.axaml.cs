using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace App;

public partial class OtchetWindow : Window
{
    public OtchetWindow()
    {
        InitializeComponent();
    }

    private void ExitButton_Click(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void RefreshButton_Click(object sender, RoutedEventArgs e)
    {
        //LoadMaterials();
    }

    private void AddOtchetButton_Click(object sender, RoutedEventArgs e)
    {
        var win = new AddEditOtchetWindow();
        win.Show();
        //LoadMaterials();
    }

    private void EditOtchetButton_Click(object sender, RoutedEventArgs e)
    {
        //if (MaterialsDataGrid.SelectedItem is MaterialDisplayDto item)
        //{
        //    var win = new AddEditOtchetWindow(item.Id);
        //    win.ShowDialog();
        //    LoadMaterials();
        //}
        //else
        //{
        //    MessageBox.Show("Выберите материал для редактирования.");
        //}
    }
}