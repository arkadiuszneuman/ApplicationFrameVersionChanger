namespace ApplicationFrameVersionChanger.VersionChanger.AssemblyInfoChanger
{
    public interface I_AssemblyInfoChanger
    {
        void ChangeAssemblyInfo(string vrpCsprojFile, string vrpOldVersion, string vrpNewVersion, bool vrpCheckoutFile);
    }
}