using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6;
public partial class AddViewModel : ObservableObject
{
    protected const string ButtonEmpty = "button_empty";
    protected const string ButtonNote = "button_note";

    [ObservableProperty]
    private string? noteIcon = ButtonEmpty;

    public void SetIcon()
    {
        try
        {
            NoteIcon = ButtonEmpty;
            NoteIcon = ButtonNote;
            NoteIcon = ButtonEmpty;
            NoteIcon = ButtonNote;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}
