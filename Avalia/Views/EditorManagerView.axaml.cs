using Avalia.Models;
using Avalia.ViewModels;
using Avalonia.Controls;
using FluentAvalonia.UI.Controls;
using System.Collections;

namespace Avalia.Views;
public partial class EditorManagerView : UserControl
{
    public EditorManagerView()
    {
        InitializeComponent();
    }

    private void OnTabCloseRequest(TabView sender, TabViewTabCloseRequestedEventArgs args)
    {
        ((EditorManagerViewModel)DataContext).Documents.Remove(args.Item as DocumentItem);
    }
}
