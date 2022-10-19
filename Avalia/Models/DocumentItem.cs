using Avalia.Views;
using AvaloniaEdit;
using FluentAvalonia.UI.Controls;

namespace Avalia.Models;
public class DocumentItem
{
    public string? Header { get; set; }

    public IconSource? IconSource { get; set; }

    public CodeEditorView? Content { get; set; }
}
