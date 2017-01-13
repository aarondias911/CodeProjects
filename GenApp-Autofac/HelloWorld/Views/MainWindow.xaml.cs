using Gen.Shell.ViewModels;
using Infrastructure.Common;
using Infrastructure.Common.Dialog;
using Prism.Events;
using System.Windows;
using System.Windows.Controls;

namespace Gen.Shell.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEventAggregator _eventAggregator;
    
        public MainWindow(MainViewModel viewModel,IEventAggregator eventAggregator)
        {
            InitializeComponent();
            this.DataContext = viewModel;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<PubSubEvent<DialogContent>>().Subscribe(OpenDialog);

          

        }

        private void OpenDialog(DialogContent dialogContent)
        {
            DialogWindow win = new DialogWindow();
            var contentUserControl = dialogContent.Content;
            win.Owner = this;
            _eventAggregator.GetEvent<PubSubEvent<DialogResult>>().Subscribe((x) =>
            {
                win.Close();
            });
            win.Content = contentUserControl;
            win.ShowInTaskbar = false;
            win.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            var dialogViewModelBase = (win.Content as UserControl).DataContext as DialogViewModelBase;
            win.ShowDialog();
        }

     
        

    }
}
