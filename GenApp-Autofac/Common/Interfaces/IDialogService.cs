using Infrastructure.Common.Dialog;
using System.Windows.Controls;

namespace Infrastructure.Common.Interfaces
{
    public interface IDialogService
    {
        DialogResult OpenDialog(UserControl content);
    }
}