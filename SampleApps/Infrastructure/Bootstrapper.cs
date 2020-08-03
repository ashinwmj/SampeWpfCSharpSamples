using System.Windows;
using Prism.Modularity;
using Prism.Unity;
using UISide.SignalManager;

namespace Shell
{
    public class Bootstrapper:UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return  new Infrastructure.Shell();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            System.Windows.Application.Current.MainWindow = (Window) this.Shell;
            System.Windows.Application.Current.MainWindow?.Show();

        }
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(SignalManagerModule));
        }
    }
    
}
