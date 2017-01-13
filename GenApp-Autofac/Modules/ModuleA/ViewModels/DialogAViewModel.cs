using Infrastructure.Common;
using Infrastructure.Common.Dialog;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class DialogAViewModel : DialogViewModelBase
    {
        //  Add the appropriate properties/methods to implement your model
        private string _title = "Dialog A";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public DelegateCommand OkCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        public DialogAViewModel(IEventAggregator eventaggregator) : base(eventaggregator)
        {
            OkCommand = new DelegateCommand(() => { CloseDialog(new DialogResult() { DialogResultType = DialogResultType.Ok }); },() => { return true; });
            CancelCommand = new DelegateCommand(() => { CloseDialog(new DialogResult() { DialogResultType = DialogResultType.Cancel}); }, () => { return true; });
        }
    }
}
