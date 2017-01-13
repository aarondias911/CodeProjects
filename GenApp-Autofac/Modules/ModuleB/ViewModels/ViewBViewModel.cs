using System;
using Common;
using Prism.Mvvm;

namespace ModuleB.ViewModels
{
    // TODO: 10.  Create a ViewModel using the standard naming convention so the
    //              AutoWireViewModel can find it.
    public class ViewBViewModel : GenViewModelBase
    {
        //  Add the appropriate properties/methods to implement your model
        private string _title = "Hello World B";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewBViewModel()
        {
            base.Header = "Hello World B";
        }
    }
    // TODO: 11.  That's it.  Run the application to see your handywork in action!
}
