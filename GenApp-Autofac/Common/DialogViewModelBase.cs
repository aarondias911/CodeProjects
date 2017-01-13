using Autofac.Core;
using Infrastructure.Common.Dialog;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common
{
    public class DialogViewModelBase : BindableBase
    {

        private IEventAggregator _eventAggregator;
        public DialogResult UserDialogResult { get; set; }

        public DialogViewModelBase(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void CloseDialog(DialogResult userDialogResult)
        {
            _eventAggregator.GetEvent<PubSubEvent<DialogResult>>().Publish(userDialogResult);
        }
    }
}
