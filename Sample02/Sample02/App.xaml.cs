using Prism.Ioc;
using Prism.Modularity;
using Sample02.Modules.ModuleName;
using Sample02.Services;
using Sample02.Services.Interfaces;
using Sample02.Views;
using System.Windows;

namespace Sample02
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
