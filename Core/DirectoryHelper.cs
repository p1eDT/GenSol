namespace _Core
{
    public class DirectoryHelper
    {
        public static string GetTestDataFolderPath()
        {
            return Environment.CurrentDirectory + "\\TestData\\";
        }

        public static string GetUserDownload()
        {
            string pathUser = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            return Path.Combine(pathUser, "Downloads\\");
        }
    }
}