using Autofac;
using Infrastructure.Common.Dialog;
using Infrastructure.Common.Interfaces;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Infrastructure.Common.Services
{
    public class DialogService : IDialogService
    {

        IEventAggregator _eventAggregator;

        public DialogService(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public DialogResult OpenDialog(UserControl content)
        {
            DialogResult dialogResult = null;
            _eventAggregator.GetEvent<PubSubEvent<DialogResult>>().Subscribe((dr) => {
                dialogResult = dr;
            });
            _eventAggregator.GetEvent<PubSubEvent<DialogContent>>().Publish(new DialogContent() { Content = content , Parameter = null});
            return dialogResult;
        }
    }
}
