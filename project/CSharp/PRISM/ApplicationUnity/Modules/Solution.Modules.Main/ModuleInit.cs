﻿using System;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using ${SolutionName}.Base.Interfaces;
using ${SolutionName}.Base.Mvvm.Interfaces;
using ${SolutionName}.Base.Names;
using ${SolutionName}.Base.Navigation;
using ${SolutionName}.Modules.Main.ViewModels;
using ${SolutionName}.Modules.Main.ViewModels.Interfaces;
using ${SolutionName}.Modules.Main.Views;

namespace ${SolutionName}.Modules.Main
{

	// Module will be initialized "as available" (by default)
	// Use this attribute when the module is rarely used:
	//[Module(ModuleName="${SolutionName}.Modules.Main", OnDemand=true)] 
	[Module(ModuleName="${SolutionName}.Modules.Main")]
	public class ModuleInit : IModule
	{
		
		IUnityContainer _container;
		IRegionManager _regionManager;
		

		public ModuleInit(IUnityContainer container, IRegionManager regionManager)
		{
			_container = container;
			_regionManager = regionManager;
		}
		

		public void Initialize()
		{

			// ViewModel Registration:
			_container.RegisterType<IFileMenuViewModel, FileMenuViewModel>();
			_container.RegisterType<IStatusBarViewModel, StatusBarViewModel>();
			
			// View Registration for ViewInjection:
			_container.RegisterType(typeof(IView), typeof(FileMenuView), typeof(FileMenuView).FullName);
			_container.RegisterType(typeof(IView), typeof(StatusBarView), typeof(StatusBarView).FullName);

			// View Injection:
			var vFileMenu = _container.Resolve(typeof(IView), typeof(FileMenuView).FullName);
			var vStatusBar = _container.Resolve(typeof(IView), typeof(StatusBarView).FullName);
			_regionManager.Regions[RegionNames.MenuRegion].Add(vFileMenu);
			_regionManager.Regions[RegionNames.StatusbarRegion].Add(vStatusBar);
			
		}

	}

}