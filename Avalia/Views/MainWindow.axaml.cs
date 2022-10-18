using Avalonia;
using Avalonia.Controls;
using FluentAvalonia.UI.Controls;

namespace Avalia.Views;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
#if DEBUG
        this.AttachDevTools();
#endif
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
    }
}
