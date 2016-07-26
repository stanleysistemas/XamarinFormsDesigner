using Ninject.Modules;
using XenForms.Core.Platform.Reflection;
using XenForms.Core.Reflection;
using XenForms.Toolbox.UI.Pouches.VisualTree;
using XenForms.Toolbox.UI.Shell;
using XenForms.Toolbox.UI.Shell.MenuItems;

namespace Toolbox.IoC
{
    public class ShellModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ConnectCommandModel>().ToSelf().InTransientScope();
            Bind<ConnectCommand>().ToSelf().InTransientScope();

            Bind<DisconnectCommand>().ToSelf().InSingletonScope();
            Bind<VisualTreePouch>().ToSelf().InTransientScope();

            Bind<SettingsDialog>().ToSelf().InTransientScope();
            Bind<SettingsCommand>().ToSelf().InTransientScope();
            Bind<IFindCustomAttributes<SettingsPanelAttribute>>()
                .To<AppDomainCustomAttributeFinder<SettingsPanelAttribute>>()
                .InSingletonScope();
        }
    }
}