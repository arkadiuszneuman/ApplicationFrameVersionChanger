namespace ApplicationFrameVersionChanger.CurrentVersionFinder
{
    public interface I_CurrentVersionFinder
    {
        string GetCurrentVersion(string vrpSlnFile);
        string GetCurrentVersionFromCsproj(string vrpCsprojFile);
    }
}