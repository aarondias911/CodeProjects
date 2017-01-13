using Autofac;
using Gen.Shell.ViewModels;
using Gen.Shell.Views;
using Infrastructure.Common.Interfaces;
using Infrastructure.Common.Services;
using Microsoft.Practices.ServiceLocation;
using ModuleA;
using ModuleA.ViewModels;
using ModuleA.Views;
using ModuleB;
using Prism.Autofac;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using Xceed.Wpf.AvalonDock;

namespace Gen.Shell
{
    //TODO: 01. Create a Bootstrapper Class using AutofacBootstrapper
    public class Bootstrapper : AutofacBootstrapper
    {
        //TODO: 02. Override the CreateShell returning an instance of your shell.
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        //TODO: 03. Override the InitializeShell setting the MainWindow on the application and showing the shell.
        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        //TODO: 04. Override the ConfigureModuleCatalog 
        protected override void ConfigureModuleCatalog()
        {
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            // In this example we are initializing a single Module in code.
            catalog.AddModule(typeof(ModuleAModule));
            catalog.AddModule(typeof(ModuleBModule));
        }

        protected override RegionAdapterMappings ConfigureRegionAdapterMappings()
        {
            // Call base method
            var mappings = base.ConfigureRegionAdapterMappings();
            if (mappings == null) return null;

            // Add custom mappings
            //mappings.RegisterMapping(typeof(DockingManager), ServiceLocator.Current.GetInstance<AvalonDockRegionAdapter>());

            // Set return value
            return mappings;
        }

        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {
            builder.RegisterType<NotificationService>().As<INotificationService>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            builder.Register<DialogService>(c => new DialogService(c.Resolve<IEventAggregator>())).As<IDialogService>().SingleInstance();
            builder.Register<MainViewModel>(c => new MainViewModel(c.Resolve<IRegionManager>(),c.Resolve<IContainer>(), c.Resolve<INotificationService>(), c.Resolve<INavigationService>()));
            builder.Register<ViewAViewModel>(c => new ViewAViewModel(c.Resolve<INotificationService>(), c.Resolve<IDialogService>()));
            builder.RegisterType<ViewA>();
            
            base.ConfigureContainerBuilder(builder);
        }

    }
}
