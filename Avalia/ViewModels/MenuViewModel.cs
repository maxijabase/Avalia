using Avalia.Interfaces;
using System;

namespace Avalia.ViewModels;
public class MenuViewModel : ViewModelBase, IMenuViewModel
{
	private readonly IEditorManagerViewModel _editorManagerViewModel;
	public MenuViewModel(IEditorManagerViewModel editorManagerViewModel)
	{
		_editorManagerViewModel = editorManagerViewModel;
	}

	public void NewCommand()
	{
		_editorManagerViewModel.AddEditor();
	}

	public void Close()
	{
		Environment.Exit(0);
	}
}
