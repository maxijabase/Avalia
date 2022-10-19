using Avalia.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
