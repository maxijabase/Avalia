using Avalia.Interfaces;
using Avalia.Models;
using Avalia.Views;
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

    public EditorManagerViewModel()
    {
        Documents = new();
    }

    public void AddEditor()
    {
        var editor = new CodeEditorView();
        editor.Editor.ShowLineNumbers = true;
        var doc = new DocumentItem
        {
            Content = editor,
            Header = $"Document {Documents.Count}",
            IconSource = new SymbolIconSource { Symbol = Symbol.CodeFilled },
            Selected = true
        };
        
        Documents.Add(doc);
        editor.Editor.TextArea.Focus();
        editor.Editor.TextArea.TextView.Focus();
    }
}
