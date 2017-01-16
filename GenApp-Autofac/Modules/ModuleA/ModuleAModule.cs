using Autofac;
using Autofac.Core;
using Infrastructure.Common.Interfaces;
using Infrastructure.Common.Model;
using ModuleA.Views;
using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using System.Collections.Generic;

//TODO: 05. Create your first Module by creating a new Class Library project and adding a ModuleInit.cs file
namespace ModuleA
{
    // TODO: 06. Implement the IModule interface
    public class ModuleAModule : Prism.Modularity.IModule
    {
        IRegionManager _regionManager;
        IMenuService _menuService;
        INavigationService _navigationService;
        IContainer _container;

        //TODO: 07.  Implement the module constructor to bring in required objects.
        //          When Prism loads the module it will instantiate this class using
        //          Autofac DI, Autofac will then inject a Region Manager instance.
        public ModuleAModule(IRegionManager regionManager, IMenuService menuService, INavigationService navigationService, IContainer container)
        {
            _regionManager = regionManager;
            _menuService = menuService;
            _navigationService = navigationService;
            _container = container;
        }

        //TODO: 08. Implement the required Initialize method to provide an entry point
        //         for your modules startup code.  Here we are registering ViewA with
        //         with the Autofac DI Container and also adding it to the "MainRegion"
        //         which was defined on the MainWindow in the Gen.Shell project.
        public void Initialize()
        {
            //_regionManager.RegisterViewWithRegion("MainRegion", typeof(ViewA));
            var subMenus = new List<SubMenu>();
            subMenus.Add(new SubMenu { Header = "Sub Menu1" , Command = new DelegateCommand(() => { _navigationService.OpenView(_container.Resolve<ViewA>()); }) });
            subMenus.Add(new SubMenu { Header = "Sub Menu2", Command = new DelegateCommand(() => { _navigationService.OpenView(_container.Resolve<ViewA>()); }) });
            subMenus.Add(new SubMenu { Header = "Sub Menu3" });
            var topMenu = new TopMenu() { Name = "Menu 1", SubMenus = subMenus};
            _menuService.AddMenu(topMenu);
        }
    }
}
