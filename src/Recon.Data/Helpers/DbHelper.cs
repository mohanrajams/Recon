namespace Recon.Data.Helpers
{
    public static class DbHelper
    {
        public static string GetSqliteConnectionString()
        {
            var dbDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");

            if (!Directory.Exists(dbDirectory))
            {
                Directory.CreateDirectory(dbDirectory);
            }

            var dbPath = Path.Combine(dbDirectory, "recon.db");

            return $"Data Source={dbPath}";
        }
    }
}
