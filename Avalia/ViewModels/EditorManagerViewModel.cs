using Avalia.Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.ViewModels;
public class EditorManagerViewModel : ViewModelBase
{
	private readonly IEditorManagerService _editorManagerService;
	public EditorManagerViewModel()
	{
	}

	public static void CloseCommand() => Environment.Exit(0);
	public static string TestString => "Hello!";
}
