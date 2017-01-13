using System;
using Common;
using Prism.Mvvm;
using Prism.Commands;
using Infrastructure.Common.Interfaces;
using Infrastructure.Common.Model;
using ModuleA.Views;
using Prism.Regions;

namespace ModuleA.ViewModels
{
    // TODO: 10.  Create a ViewModel using the standard naming convention so the
    //              AutoWireViewModel can find it.
    public class ViewAViewModel : GenViewModelBase, INavigationAware
    {
        //  Add the appropriate properties/methods to implement your model
        private string _title = "Hello World A";

        public DelegateCommand NotificationCommand { get; set; }
        public DelegateCommand InteractionCommand { get; set; }
        
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewAViewModel(INotificationService notificationService,IDialogService dialogService)
        {
            base.Header = "Hello World A";
            NotificationCommand = new DelegateCommand(() =>  { notificationService.AddNotification("Hi", "Hiii", NotificationType.Info); }, () => { return true; });
            InteractionCommand = new DelegateCommand(() => 
            {
                dialogService.OpenDialog(new DialogAView());
            }, () => { return true; });
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }
    }
    // TODO: 11.  That's it.  Run the application to see your handywork in action!
}
