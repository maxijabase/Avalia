using Avalia.Interfaces;
using System;

namespace Avalia.ViewModels;

public class MainWindowViewModel : ViewModelBase, IMainWindowViewModel
{
    public MainWindowViewModel(
        IEditorManagerViewModel editorManagerViewModel,
        IMenuViewModel menuViewModel)
    {
        EditorManagerViewModel = editorManagerViewModel;
        MenuViewModel = menuViewModel;
    }

    public IEditorManagerViewModel EditorManagerViewModel { get; set; }
    public IMenuViewModel MenuViewModel { get; set; }

    public void ExitCommand() => Environment.Exit(0);
}
