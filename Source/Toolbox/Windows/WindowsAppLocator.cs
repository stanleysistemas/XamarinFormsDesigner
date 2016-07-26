using System;
using Microsoft.Win32;
using XenForms.Core.Toolbox;

namespace XenForms.Windows
{
    public class WindowsAppLocator : IAppLocator
    {
        public string GetVisualStudioInstallFolder(string version)
        {
            try
            {
                var path = $@"SOFTWARE{(Environment.Is64BitProcess ? @"\Wow6432Node\" : "\\")}Microsoft\VisualStudio\{version}";

                using (var entry = Registry.LocalMachine.OpenSubKey(path))
                {
                    return entry?.GetValue("InstallDir") as string;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetAdbInstallFolder()
        {
            try
            {
                var path = $@"SOFTWARE{(Environment.Is64BitProcess ? @"\Wow6432Node\" : @"\")}Android SDK Tools";

                using (var entry = Registry.LocalMachine.OpenSubKey(path))
                {
                    return entry?.GetValue("Path") as string;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
