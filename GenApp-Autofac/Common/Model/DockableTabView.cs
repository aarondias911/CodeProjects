using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Xceed.Wpf.AvalonDock.Layout;

namespace Infrastructure.Common.Model
{
    public class DockableTabView : INotifyPropertyChanged
    {
        bool _isActive;
        bool _isSelected;

        public DockableTabView()
        {
            
        }

      

        public string ViewId { get; set; }
        public string Header { get; set; }

        public  FrameworkElement View { get; set; }

        public DelegateCommand CloseCommand { get; set; }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }

            set
            {
                _isActive = value;
                RaisePropertyChanged("IsActive");
            }
        }

        public bool IsSelected
        {
            get
            {
                return _isSelected;
            }

            set
            {
                _isSelected = value;
                RaisePropertyChanged("IsSelected");
            }
        }

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
