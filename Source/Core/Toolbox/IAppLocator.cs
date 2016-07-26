namespace XenForms.Core.Toolbox
{
    public interface IAppLocator
    {
        string GetVisualStudioInstallFolder(string version);
        string GetAdbInstallFolder();
    }
}