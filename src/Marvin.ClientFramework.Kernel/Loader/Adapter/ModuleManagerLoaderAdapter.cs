﻿using Marvin.ClientFramework.Kernel.Properties;
using Marvin.Container;

namespace Marvin.ClientFramework.Kernel
{
    /// <summary>
    /// Module manager loader adapter
    /// </summary>
    [KernelComponent(typeof(ILoaderAdapter))]
    public class ModuleManagerLoaderAdapter : LoaderAdapterBase, ILoaderAdapter
    {
        /// <inheritdoc />
        public bool CanAdapt(object component)
        {
            return component is IModuleManager;
        }

        /// <inheritdoc />
        public void Adapt(object component)
        {
            var moduleManager = (IModuleManager) component;

            moduleManager.StartInitilizingModules += OnStartInitilizingModules;
            moduleManager.StartInitializeModule += OnStartInitializeModule;
            moduleManager.InitializingModuleDone += OnInitializingModuleDone;
        }

        private void OnStartInitilizingModules(object sender, int i)
        {
            RaiseAddToMax(i);
        }

        private void OnStartInitializeModule(object sender, IClientModule clientModule)
        {
            RaiseChangeMessage(string.Format(strings.Loader_InitializingModule, clientModule.Name));
        }

        private void OnInitializingModuleDone(object sender, IClientModule clientModule)
        {
            RaiseChangeValueWithMessage(string.Format(strings.Loader_InitializingModuleDone, clientModule.Name));
        }
    }
}