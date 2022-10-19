using Avalia.Backend.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.Backend.Services;
public class EditorManagerService : IEditorManagerService
{
    public void TestClose()
    {
        Environment.Exit(0);
    }
}
