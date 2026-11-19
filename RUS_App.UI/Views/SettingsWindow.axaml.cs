using Avalonia.Controls;
using Avalonia.Interactivity;

namespace RUS_App.UI.Views;

public partial class SettingsWindow : Window
{
    public SettingsWindow() => InitializeComponent();

    private void OnClose(object? sender, RoutedEventArgs e) => Close();
}
