﻿using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Marvin.ClientFramework.Dialog;
using Marvin.ClientFramework.History;
using Marvin.Container;
using Marvin.Tools.Wcf;

namespace Marvin.ClientFramework.Shell
{
    /// <summary>
    /// Base view model for the application shells. 
    /// </summary>
    public abstract class ShellViewModelBase : Conductor<ModuleWrapper>.Collection.OneActive, IModuleShell
    {
        #region Dependency Injection

        public IModuleManager ModuleManager { get; set; }
        
        public IHistory History { get; set; }
        
        public IDialogManager DialogManager { get; set; }
        
        public IWindowManager WindowManager { get; set; }
        
        public IConfigProvider ConfigProvider { get; set; }
        
        public IKernelConfigManager KernelConfigManager { get; set; }
        
        public IWcfClientFactory WcfClientFactory { get; set; }
        
        public IAppDataConfigManager AppDataConfigManager { get; set; }

        public IModuleContainerFactory ContainerFactory { get; set; }

        #endregion

        #region Fields and properties

        /// <summary>
        /// Contains the created region controller
        /// </summary>
        protected IShellRegionController RegionController { get; private set; }

        #endregion

        #region IModuleShell

        void IModuleShell.Initialize()
        {
            RegionController = CreateController();
            RegionController.Initialize(ContainerFactory, ModuleManager, ConfigProvider);

            //register components needed in the shell container
            RegionController.Register(KernelConfigManager);
            RegionController.Register(WindowManager);
            RegionController.Register(WcfClientFactory);
            RegionController.Register(AppDataConfigManager);

            var enabledModules = ModuleManager.EnabledModules.OfType<IWorkspaceModule>();

            Items.AddRange(WrapModules(enabledModules));
            History.WorkspaceChanged += HistoryOnWorkspaceChanged;
        }

        /// <summary>
        /// Creates the shell region controller for the current shell
        /// </summary>
        protected abstract IShellRegionController CreateController();

        #endregion

        #region History

        /// <summary>
        /// Pushes the given mdule to the main workspace.
        /// </summary>
        public void SelectModule(ModuleWrapper wrapper)
        {
            History.Push(wrapper.Module);
        }

        /// <summary>
        /// Pushes the next workspace
        /// </summary>
        public void HistoryNext()
        {
            History.MoveNext();
        }

        /// <summary>
        /// Pushes the previous workspace
        /// </summary>
        public void HistoryPrevious()
        {
            History.MovePrevious();
        }

        private void HistoryOnWorkspaceChanged(object sender, WorkspacePair workspacePair)
        {
            var wrapper = Items.First(item => item.Module == workspacePair.Module);
            wrapper.ChangeWorkspace(workspacePair.Workspace);

            ActiveItem = wrapper;
        }

        #endregion

        protected Region FetchRegion(string regionName)
        {
            var region = RegionController.FetchRegion(regionName);
            ((IShellRegion)region.Content).ConnectToShell(this);
            return region;
        }

        private static IEnumerable<ModuleWrapper> WrapModules(IEnumerable<IWorkspaceModule> modules)
        {
            return modules.OrderBy(m => m.Config.SortIndex).Select(cm => new ModuleWrapper(cm));
        }
    }
}