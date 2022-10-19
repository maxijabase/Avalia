using Avalia.Interfaces;
using Avalia.Models;
using FluentAvalonia.UI.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.ViewModels;
public class EditorManagerViewModel : ViewModelBase, IEditorManagerViewModel
{
    public ObservableCollection<DocumentItem> Documents { get; set; }
    public int index = 0;

    public EditorManagerViewModel()
    {
        Documents = new();
        AddEditor();
    }

    public void AddEditor()
    {
        var doc = new DocumentItem
        {
            Content = new(),
            Header = $"header {index}",
            IconSource = new SymbolIconSource { Symbol = Symbol.Code }
        };
        Documents.Add(doc);
        index++;
    }
}
