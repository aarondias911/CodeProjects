using Autofac;
using Infrastructure.Common.Interfaces;
using ModuleA.Views;
using Prism.Commands;
using Prism.Regions;
using System.Linq;
using Infrastructure.Common.Model;
using System.Collections.ObjectModel;
using Common;
using ModuleB.Views;

namespace Gen.Shell.ViewModels
{
    public class MainViewModel : GenViewModelBase
    {
        public DelegateCommand NavigateToViewA { get; set; }
        public DelegateCommand NavigateToViewB { get; set; }
        public ObservableCollection<NotificationMessage> NotificationMessages { get; set; }
        public ObservableCollection<DockableTabView> DockableTabViews { get; set; }
        

        public MainViewModel(IRegionManager regionManager, Autofac.IContainer container, INotificationService notificationService, INavigationService navigationService)
        {
            DockableTabViews = new ObservableCollection<DockableTabView>();
           
            navigationService.OnNavigationRequested += NavigationService_OnNavigationRequested;

            NavigateToViewA = new DelegateCommand(() => { navigationService.OpenView(container.Resolve<ViewA>()); } , () => { return true; });
            NavigateToViewB = new DelegateCommand(() => { navigationService.OpenView(container.Resolve<ViewB>()); }, () => { return true; });

            NotificationMessages = new ObservableCollection<NotificationMessage>();
            notificationService.NotificationAdded += NotificationService_NotificationAdded;

        }

        private void NavigationService_OnNavigationRequested(DockableTabView obj)
        {
            var view = DockableTabViews.FirstOrDefault(x => x.ViewId == obj.ViewId);
            if (view == null)
            {
                obj.CloseCommand = new DelegateCommand(() =>
                {
                    DockableTabViews.Remove(obj);
                }, () => { return true; });
                DockableTabViews.Add(obj);
            }
            else
            {

                for(int i =0;i< DockableTabViews.Count;i++ )
                {
                    DockableTabViews[i].IsSelected = false;
                    DockableTabViews[i].IsActive = false;
                }
             

                int index = DockableTabViews.IndexOf(view);
                DockableTabViews[index].IsSelected = true;
                DockableTabViews[index].IsActive = true;
                OnPropertyChanged(() => DockableTabViews);
            }
        }

       

        private void NotificationService_NotificationAdded(NotificationMessage messages)
        {
            NotificationMessages.Add(messages);
        }

    
    }
}
