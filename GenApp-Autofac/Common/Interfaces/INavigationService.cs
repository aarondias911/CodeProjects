using System;
using System.Windows.Controls;
using Infrastructure.Common.Model;

namespace Infrastructure.Common.Interfaces
{
    public interface INavigationService
    {
        event Action<DockableTabView> OnNavigationRequested;

        void OpenView(UserControl view);
    }
}