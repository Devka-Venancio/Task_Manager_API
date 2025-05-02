namespace Task_Manager_API.Configurations
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            var user = Environment.GetEnvironmentVariable("DB_User");
            var password = Environment.GetEnvironmentVariable("DB_Password");
            return $"Server=localhost;Database=devka_tasks;User Id={user};Password={password};";
        }

    }
}
