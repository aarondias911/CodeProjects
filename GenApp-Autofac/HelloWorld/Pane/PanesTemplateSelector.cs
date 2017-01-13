namespace Gen.Shell.Pane
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Controls;
    using System.Windows;
    using Xceed.Wpf.AvalonDock.Layout;
    using Infrastructure.Common.Model;

    class PanesTemplateSelector : DataTemplateSelector
    {
        public PanesTemplateSelector()
        {
        
        }


        public DataTemplate TabViewTemplate
        {
            get;
            set;
        }

        public DataTemplate ToolsViewTemplate
        {
            get;
            set;
        }

        public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container)
        {
           var itemAsLayoutContent = item as ContentPresenter;
            if (itemAsLayoutContent != null)
            {
                if (itemAsLayoutContent.Content is DockableTabView)
                    return TabViewTemplate;
            }

            return base.SelectTemplate(item, container);
        }
    }
}
