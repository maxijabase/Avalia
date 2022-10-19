using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;

namespace Avalia.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
	public MainWindowViewModel()
	{
	}

    public static void ExitCommand() => Environment.Exit(0);

	public EditorManagerViewModel EditorManagerViewModel { get; set; }
}
