using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infrastructure.Common.Model
{
    public class SubMenu : MenuItem
    {
        public UserControl View { get; set; }
    }
}
