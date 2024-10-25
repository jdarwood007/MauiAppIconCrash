using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp6;
public partial class AddViewModel : INotifyPropertyChanged
{
    protected const string ButtonEmpty = "button_empty";
    protected const string ButtonNote = "button_note";

    private string? noteIcon = ButtonEmpty;
    public string NoteIcon
    {
        get => noteIcon ?? ButtonEmpty;
        set => SetProperty(ref noteIcon, value);
    }

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

    protected bool SetProperty<T>(ref T backingStore, T value,
    [CallerMemberName] string propertyName = "",
    Action? onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
        {
            return false;
        }

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        try
        {
            PropertyChangedEventHandler? changed = PropertyChanged;
            if (changed == null)
            {
                return;
            }

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
    #endregion

}
