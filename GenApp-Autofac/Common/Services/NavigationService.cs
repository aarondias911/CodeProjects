using System;
using Autofac;
using System.Windows.Controls;
using Infrastructure.Common.Model;
using Common;
using Infrastructure.Common.Interfaces;

namespace Infrastructure.Common.Services
{
    public class NavigationService : INavigationService
    {
        IContainer _container;

        public event Action<DockableTabView> OnNavigationRequested;

        public NavigationService(IContainer container)
        {
            _container = container;
            OnNavigationRequested = new Action<DockableTabView>((x) => { });
        }

        public void OpenView(UserControl view)
        {
            DockableTabView dockableTabView = new DockableTabView();

            dockableTabView.View = view;
            dockableTabView.Header = (view.DataContext as GenViewModelBase).Header;
            dockableTabView.ViewId = view.ToString();
            dockableTabView.IsActive = true;
            dockableTabView.IsSelected = true;
            OnNavigationRequested.Invoke(dockableTabView);
        }
       
        
    
    }
}
