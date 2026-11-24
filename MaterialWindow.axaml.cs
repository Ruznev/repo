using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;

namespace App;

public partial class MaterialWindow : Window
{
    public MaterialWindow()
    {
        InitializeComponent();
    }


    private void ExitButton_Click(object? sender, RoutedEventArgs e)
    {
        new MainWindow().Show();
    }

     private void AddMaterialButton_Click(object sender, RoutedEventArgs e)
    {
        var win = new AddEditOtchetWindow();
        win.Show();
        //LoadMaterials();
    }

    private void EditMaterialButton_Click(object sender, RoutedEventArgs e)
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